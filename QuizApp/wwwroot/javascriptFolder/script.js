
var checkbox = document.getElementById("check").addEventListener('click', function () {
    if (checkbox.checked) {
        alert("checked");
    }
});
checkbox.checked = true;
console.log(checkbox);
if (checkbox.checked) {
    alert("checked");
}