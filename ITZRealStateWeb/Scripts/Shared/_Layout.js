function EditUserjs(id) {
    $("#site_content").hide("slow").load('/User/Edit/'+id).show("slow");
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

function DesireList() {
    $("#site_content").hide("slow").load('/Desire').show("slow");
}

function EditUserjs(id) {
    $("#site_content").hide("slow").load('/User/Edit/' + id).show("slow");
}

function CreateListing() {
    $("#site_content").hide("slow").load('/Listing/Create').show("slow");
}

function Listings() {
    $("#site_content").hide("slow").load('/Listing').show("slow");
}