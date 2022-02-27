$(function () {

    var errorText = "An error has occured. An administrator has been notified. Please try again later!";
    $("button[name='SavedSelectedUsers']").prop('disabled', true);

    $('select').on('change', function () {
        var url = "/TheAdmin/UsersToCategory/GetUsersForCategory?categoryId=" + this.value;

        if (this.value != 0) {
            $.ajax(
                {
                    type: "GET",
                    url: url,
                    success: function (data) {
                        $("UsersCheckList").html(data);
                        $("button[name='SaveSelectedUsers']").prop('disabled', false);

                    },
                    error: function (xhr, ajaxOptions, thrownError) {
                        PresentClosableBootstrapAlert("#alert_placeholder", "danger", "An error occured!", errorText);
                        console.error("An error has occurred: " + thrownError + "Status: " + xhr.statusText + "\r\n" + xhr.responseText);
                    }

                }

            );


        }
        else {
            $("button[name='SaveSelectedUsers']").prop('disabled', true);
            $("input[type=checkbox]").prop("checked", false);
            $("input[type=checkbox]").prop("disabled", true);

        }
    });

    $('#SaveSelectedUsers').click(function () {
        var url = "TheAdmin/UsersToCategory/SaveSelectedUsers";

        var categoryId = $("#CategoryId").val();

        var antiForgeryToken = $("input[name='__RequestVerificationToken']").val();

        var usersSelected = [];

        DisbaleControls(true);

        $(".progress").show("fade");


        $('input[type=checkbox]:checked').each(function (){
            var userModel = {
                Id: $(this).attr("value")
            };
            usersSelected.push(userModel);
        });
        var usersSelectedForCategory = {
            __RequestVerificationToken: antiForgeryToken,
            CategoryId: categoryId,
            UsersSelected: usersSelected
        };
        $.ajax(
            {
                type: "POST",
                url: url,
                data: usersSelectedForCategory,
                success: function (data) {
                    $("#UsersCheckList").html(data);

                    $(".progress").hide("fade", function () {
                        $(".alert-success").fadeTo(2000, 500).slideUp(500, function () {
                            DisbaleControls(false);

                        });
                    });
                },
                error: function (xhr, ajaxOptions, thrownError) {
                    $(".progress").hide("fade", function () {

                        PresentClosableBootstrapAlert("#alert_placeholder", "danger", "An error occured!", errorText);
                        console.error("An error has occurred: " + thrownError + "Status: " + xhr.statusText + "\r\n" + xhr.responseText);

                        DisbaleControls(false);
                    });

                }   

            }

        );
        function DisbaleControls(disable) {
            $('input[type=checkbox]').prop("disabled", disable);
            $("#SaveSelectedUsers").prop('disabled', disable);
            $('select').prop('disabled', disable);

        }

    });
});