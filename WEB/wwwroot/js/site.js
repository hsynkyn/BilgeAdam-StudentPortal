// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function loadTeachersByCourseId(courseId, selectedTeacherId = null, selectedClassroomId = null) {
    //console.log(courseId);
    if (courseId) {
        $.ajax({
            url: '/Education/Teachers/GetTeachersByCourseId',
            type: 'GET',
            data: { courseId: courseId },
            success: function (data) {
                console.log(data)
                var teachers = $("#teachers");
                teachers.attr('disabled', false);
                teachers.empty();

                if (data.length === 0) {
                    teachers.append('<option disabled selected value="0">Bu kursta eğitmen yoktur!</option>')
                    teachers.attr('disabled', true);
                } else {
                    teachers.append('<option disabled selected value="0">Lütfen eğitmen seçiniz!</option>');
                    var classrooms = $("#classrooms");
                    classrooms.empty();
                    classrooms.attr('disabled', true);
                    classrooms.append('<option disabled selected value="0">Lütfen sınıf seçiniz!</option>');
                    $.each(data, function (index, teacher) {
                        const selected = teacher.id == selectedTeacherId ? 'selected' : '';
                        teachers.append(`<option value="${teacher.id}" ${selected}>${teacher.fullName}</option>`);
                    })

                    if (selectedClassroomId) {
                        loadClassroomsByTeacherId(selectedTeacherId, selectedClassroomId);
                    }
                }
            },
            error: function (err) {
                console.log(err)
            }
        })
    }
}

function loadClassroomsByTeacherId(teacherId, selectedClassroomId = null) {
    if (teacherId) {
        $.ajax({
            url: '/Education/Classrooms/GetClassroomsByTeacherId',
            type: 'GET',
            data: { teacherId: teacherId },
            success: function (data) {
                console.log(data)
                var classrooms = $("#classrooms");
                classrooms.attr('disabled', false);
                classrooms.empty();

                if (data.length === 0) {
                    classrooms.append('<option disabled selected value="0">Bu eğitmenin sınıfı yoktur!</option>')
                    classrooms.attr('disabled', true);
                } else {
                    classrooms.append('<option disabled selected value="0">Lütfen sınıf seçiniz!</option>');
                    $.each(data, function (index, classroom) {
                        const selected = classroom.id == selectedClassroomId ? 'selected' : '';
                        classrooms.append(`<option value="${classroom.id}" ${selected}>${classroom.name}</option>`);
                    })
                }
            },
            error: function (err) {
                console.log(err)
            }
        })
    }
}

function studentUploadImage(uploadImage) {
    console.log(uploadImage)
    if (uploadImage.files && uploadImage.files[0]) {
        $("#studentImg").attr("src", URL.createObjectURL(uploadImage.files[0]))
    }
}
var logoutBtn = document.getElementById("logoutBtn");
if (logoutBtn) {
    const logoutUrl = logoutBtn.dataset.logoutUrl;
    $('#logoutBtn').on("click", function (e) {
        e.preventDefault();

        Swal.fire({
            title: 'Çıkış yapmak istediğinize emin misiniz?',
            icon: 'warning',
            showCancelButton: true,
            confirmButtonText: 'Evet',
            cancelButtonText: 'İptal',
            reverseButtons: true
        }).then((result) => {
            if (result.isConfirmed) {
                // Logout linkine yönlendir
                window.location.href = logoutUrl;
            }
        });
    });
}

$(function () {

    const messageContainer = $('#swalMessages');

    const successMessage = messageContainer.data('success');

    const errorMessage = messageContainer.data('error');

    if (successMessage) {

        Swal.fire({

            title: 'Başarılı!',

            text: successMessage,

            icon: 'success',

            html: successMessage

        });

    }

    if (errorMessage) {

        Swal.fire({

            title: 'Hata!',

            text: errorMessage,

            icon: 'error',

            html: errorMessage

        });

    }

});
