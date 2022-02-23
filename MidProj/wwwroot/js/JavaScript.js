function selectedCategory() {
    let id = document.getElementById("selectedcategory").value;
    window.location.href = "/Catalog/Catalog/" + id;
}
function AddComment(id) {
    let comment = document.getElementById("commentstring").value;
    window.location.href = "/Catalog/AddComment/?id=" + id + "&comment=" + comment;

} 
function selectedCategoryOnAdminView() {
    let id = document.getElementById("selectedcategoryonadminview").value;
    window.location.href = "/Admin/Admin/" + id;
}
