function PresentClosableBootstrapAlert(placeHolderElmId, alertType, alertHeading, alertMessage) {

    if (alertType == "") {
        alertType = "info";
    }
    var alertHtml = '<div class="alert alert-' + alertType + ' alert-dismissible fade show" role="alert"> ' +
        '<strong>' + alertHeading + '</strong><br>' + alertMessage
                    '<button type="button" class="close" data-dismiss="alert" aria-label="Close">' +
                    '<span aria-hidden="true">&times;</span>' +
                    '</button>' +
                    '</div>';

    $(placeHolderElmId).html(alertHtml);
}

function CloseAlert(placeHolderElmId) {
    $(placeHolderElmId).html(alertHtml);
}