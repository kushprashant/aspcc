function numberOnly(obj)
{
    var objid = "#" + obj.id;
    var value = $(objid).val();
    if (!value.match(/^\d+/)) {
        $(objid).val('');
    }
}

function isEmail(obj) {
    var objid = "#" + obj.id;
    var value = $(objid).val();
    var regex = /^([a-zA-Z0-9_.+-])+\@(([a-zA-Z0-9-])+\.)+([a-zA-Z0-9]{2,4})+$/;
    if (!regex.test(email)) {
        $(objid).val('');
    }
}

/*Notification fucntion*/
          
toastr.options = {
    "closeButton": false,
    "debug": false,
    "newestOnTop": false,
    "progressBar": false,
    "positionClass": "toast-top-right",
    "preventDuplicates": false,
    "onclick": null,
    "showDuration": "1000",
    "hideDuration": "2000",
    "timeOut": "1000",
    "extendedTimeOut": "1000",
    "showEasing": "swing",
    "hideEasing": "linear",
    "showMethod": "fadeIn",
    "hideMethod": "fadeOut"
};
function showNofication(type, title, msg) {
    var $toast = toastr[type](msg, title); // Wire up an event handler to a button in the toast, if it exists
    $toastlast = $toast;
}

function getage(dob) {
    var dd = dob.split('-')[0];
    var mm = dob.split('-')[1];
    var yy = dob.split('-')[2]
    var dob = yy + '-' + mm + '-' + dd;
    dob = new Date(dob);
    var today = new Date();
    var age = Math.floor((today - dob) / (365.25 * 24 * 60 * 60 * 1000));
    return age;
}
