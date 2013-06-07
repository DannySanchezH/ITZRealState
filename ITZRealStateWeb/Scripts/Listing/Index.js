
//____________________________LISTINGS___________________________________________

//Since Dashboard on Create New
function CreateListing(id) {
    $("#site_content").hide("slow").load('/Listing/Create/' + id).show("slow");
}

//Since site_content on Delete
function editListing(id) {
    $("#site_content").hide("slow").load('/Listing/Edit/' + id).show("slow");
}


//_____________In Create Listing_________
//Submit Create Listing
function submitCreate(form) {
    if (!$(frm).valid()) { return false; }
    $.post($(frm).attr("action"), $(frm).serialize(), function (data) {
        if (data.contactId != null) {
            $("#site_content").hide("slow");
        } else {
            $("#site_content").hide("slow");
        }
    });
    return false;
}

//Submit Edit Listing
function submitEdit(frm) {
    if (!$(frm).valid()) { return false; }
    $.post($(frm).attr("action"), $(frm).serialize(), function (data) {
        $("#site_content").hide("slow").load('/Listing/').show("slow");
        document.location.reload(true);
    });
    return false;
}

function cancel() {
    $("#site_content").hide("slow").load('/Listing/').show("slow");
}

//  Methods to Checkbuttons of Rooms and Amenities

/*$(document).ready(function () {
    alert("roomsag");
});*/
function getRoom(id,type){
    $(".room").appendChild("<input id='" + idRoom + "' type='checkbutton' name='" + type + "'> " + type);
    
}

