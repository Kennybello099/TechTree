using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechTreeMVC.Areas.TheAdmin.Models;
using TechTreeMVC.Data;
using TechTreeMVC.Entities;

namespace TechTreeMVC.Areas.TheAdmin.Controllers
{
    [Area("TheAdmin")]
    [Authorize(Roles = "Admin")]
    public class UsersToCategoryController : Controller
    {

        private readonly ApplicationDbContext _context;

        public UsersToCategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        [HttpGet]
        public async Task<IActionResult> GetUsersForCategory(int categoryId)
        {
            UsersCategoryListModel usersCategoryListModel = new UsersCategoryListModel();

            var allUsers = await GetAllUsers();

            var selectedUsersForCategory = await GetSavedSelectedUsersForCategory(categoryId);

            usersCategoryListModel.Users = allUsers;

            usersCategoryListModel.UsersSelected = selectedUsersForCategory;

            return PartialView("_UserListViewPartial", usersCategoryListModel);

        }
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.ToListAsync());
        }

        public async Task<IActionResult> SaveSelectedUsers([Bind("CategoryId, UsersSelected")] UsersCategoryListModel usersCategoryListModel)
        {
            List<UserCategory> usersSelectedForCategoryToAdd = null;

            if(usersCategoryListModel.UsersSelected != null)
            {
                usersSelectedForCategoryToAdd = await GetUsersForCategoryToAdd(usersCategoryListModel);

            }

            var usersSelectedForCategoryToDelete = GetUsersForCategoryToDelete(usersCategoryListModel.CategoryId);

            using (var dbContextTransaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {

                    _context.RemoveRange(usersSelectedForCategoryToDelete);
                    await _context.SaveChangesAsync();

                    if (usersSelectedForCategoryToAdd != null)
                    {
                        _context.AddRange(usersSelectedForCategoryToAdd);
                        await _context.SaveChangesAsync();

                    }
                    await dbContextTransaction.CommitAsync();
                }

                catch (Exception ex)
                {
                    await dbContextTransaction.DisposeAsync();
                }


            }

            System.Threading.Thread.Sleep(2000);

            usersCategoryListModel.Users = await GetAllUsers();

            return PartialView("_UserListViewPartial", usersCategoryListModel);

        }
        private async Task<List<UserModel>> GetAllUsers()
        {
            var allUsers = await (from user in _context.Users
                                  select new UserModel
                                  {
                                      Id = user.Id,
                                      UserName = user.UserName,
                                      LastName = user.LastName,
                                      FirstName = user.FirstName
                                  }).ToListAsync();

            return allUsers;
                                 
        }
        private async Task<List<UserCategory>> GetUsersForCategoryToAdd(UsersCategoryListModel usersCategoryListModel)
        {
            var usersForCategoryToAdd = (from userCat in usersCategoryListModel.UsersSelected
                                         select new UserCategory
                                         {
                                             CategoryId = usersCategoryListModel.CategoryId,
                                             UserId = userCat.Id
                                         }).ToList();

            return await Task.FromResult(usersForCategoryToAdd);                  
        }
        private async Task<List<UserCategory>> GetUsersForCategoryToDelete(int categoryId)
        {
            var usersForCategoryToDelete = await (from userCat in _context.UserCategories
                                         where userCat.CategoryId == categoryId
                                         select new UserCategory
                                         {
                                             Id = userCat.Id,
                                             CategoryId = categoryId,
                                             UserId = userCat.UserId

                                         }).ToListAsync();


            return usersForCategoryToDelete;
        }
        private async Task<List<UserModel>> GetSavedSelectedUsersForCategory(int categoryId)
        {
            var savedSelectedUsersForCategory = await (from usersToCat in _context.UserCategories
                                                       where usersToCat.CategoryId == categoryId
                                                       select new UserModel
                                                       {
                                                           Id = usersToCat.UserId

                                                       }).ToListAsync();

            return savedSelectedUsersForCategory;
        }
    }
        
}
