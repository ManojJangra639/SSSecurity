var Registration = {
    Init: function () {
        $(document).on('click', '#registration', function () {
            let user = {
                fName:$('#fName').val(),
                lName:$('#lName').val(),
                email:$('#email').val(),
                phone:$('#phone').val(),
                adhaar:$('#adhaar').val(),
                pan:$('#pan').val(),
                address:$('#address').val(),
                currentAddress:$('#currentAddress').val(),
                pin:$('#pin').val(),
                currentPin: $('#currentPin').val(),
            }

            if (user != null && user != undefined) {
                Registration.SaveUser(user);
            }
        });
    },
    SaveUser: function () {

    }
}

$(function () {
    Registration.Init();
});