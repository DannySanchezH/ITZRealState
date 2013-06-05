//____________________________LISTINGS___________________________________________

function CreateListing(id) {
    $("#site_content").hide("slow").load('/Listing/Create/' + id).show("slow");
}

function editListing(id) {
    $("#site_content").hide("slow").load('/Listing/Edit/' + id).show("slow");
}

//Create Listing
function submitCreate(form) {
    if (!$(frm).valid()) { return false; }
    $.post($(frm).attr("action"), $(frm).serialize(), function (data) {
        if (data.contactId != null) {
            $("#site_content").hide("slow");
            updateTable(data);
        } else {
            $("#site_content").hide("slow");
        }
    });
    return false;
}

//Edit Listing
function submitEdit(frm) {
    if (!$(frm).valid()) { return false; }
    $.post($(frm).attr("action"), $(frm).serialize(), function (data) {
        updateTable(data);
        document.location.reload(true);
    });
    return false;
}

function cancel() {
    $("#site_content").hide("slow").load('/Listing/').show("slow");
}


function deleteListing(id) {
    
}


