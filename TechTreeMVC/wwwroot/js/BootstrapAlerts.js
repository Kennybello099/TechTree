function PresentClosableBootstrapAlert(placeHolderElemId, alertType, alartHeading, alertMessage) {
    if (alertType == "") {
        alertType = "Info";
    }
    var alertHtml = '<div class="alert alert-' + alertType + ' alert-dismissible fade show" role="alert">' +
        '<strong>' + alartHeading + '</strong><br>' + alertMessage
        '<button type="button" class="close" data-dismiss="alert" aria-lable="Close">' +
        '<span aria-hidden="true">&times;</span>' +
        '</button>' +
        '</div>';

    $(placeHolderElemId).html(alertHtml);
}
function CloseAlert(placeHolderElemId) {
    $(placeHolderElemId).html(alertHtml);
}