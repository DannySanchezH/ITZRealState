function EditUserjs() {
    $("#site_content").hide("slow").load('/User/Edit/1').show("slow");
}

function CancelEditU() {
    $("#site_content").hide("slow");
}

function submitEdit(frm) {
    if (!$(frm).valid()) { return false; }
    $.post($(frm).attr("action"), $(frm).serialize(), function (data) {
        document.location.reload(true);
    });
    return false;
}