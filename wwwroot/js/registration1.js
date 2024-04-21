$(document).ready(function () {
    $("#uploadButton").click(function () {
        var formData = new FormData();
        var fileInput = $("#fileInput")[0];
        $.each(fileInput.files, function (i, file) {
            formData.append("files", file);
        });

        $.ajax({
            url: "/Home/Upload",
            type: "POST",
            data: formData,
            processData: false,
            contentType: false,
            xhr: function () {
                var xhr = new window.XMLHttpRequest();
                xhr.upload.addEventListener("progress", function (e) {
                    if (e.lengthComputable) {
                        var progress = (e.loaded / e.total) * 100;
                        $("#progressBar").css("width", progress + "%");
                    }
                }, false);
                return xhr;
            },
            success: function () {
                alert("Upload successful!");
                $("#progressBar").css("width", "0%");
                $("#fileInput").val(""); // Clear file input
            },
            error: function () {
                alert("Upload failed!");
            },
            beforeSend: function () {
                $("#progressBarContainer").show();
            },
            complete: function () {
                $("#progressBarContainer").hide();
            }
        });
    });
});
</script >
