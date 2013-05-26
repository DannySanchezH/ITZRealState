function EditUserjs(id) {
    $("#site_content").hide("slow").load('/User/Edit/' + id).show("slow");
}