
    $('#login').submit(function () {
        $.ajax({
            url: $('#login').attr('action'),
            type: 'POST',
            data: $('#login').serialize(),
            success: function (response) {
                var user = JSON.parse(response);
                if (user.success == 0) {
                    $('#loginfailed').append(user.message);
                }
                else
                    location.href = "/home";
            }
        });
        return false;
    });
