// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.




var done = document.querySelectorAll("input[type=checkBox]");

//console.log(formDone);
function changeDone(item) {
    var formName = "tickForm" + item.id;
    var formEdit = document.forms.FormName;
    formDone.submit(formEdit);

}

for (let i = 0; i < done.length; i++) {
    done[i].addEventListener("change", changeDone(this));
}