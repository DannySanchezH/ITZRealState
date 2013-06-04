
//Limpia caja de texto "input"
$(document).ready(function () {
    var valor,val2;
    $("input").click(function () {
        valor = $(this).attr("value");
        $(this).attr("value", "");        
    });
    $("input").focusout(function () {
        val2= $(this).attr("value");
        if (val2 === "") {
            $(this).attr("value", valor);
        }
    });
});



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

function DesireList(id) {
    $("#site_content").hide("slow").load('/Desire/Index/' + id).show("slow");
}

<<<<<<< HEAD
=======
function EditUserjs(id) {
    $("#site_content").hide("slow").load('/User/Edit/' + id).show("slow");
}

function CreateListing() {
    $("#site_content").load('/Listing/Create').show("slow");
}

>>>>>>> Create Listings
function Listings() {
    $("#site_content").hide("slow").load('/Listing').show("slow");
}

function Agents() {
<<<<<<< HEAD
    $("#site_content").load('/User').show("slow");
}
=======
    $("#site_content").load('/SalesAgent').show("slow");
}


//____________________________LISTINGS___________________________________________
function createListing(form) {
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
function cancelListing() {
    $("#site_content").hide("slow");
}

//Edit Listing
function editListing(id) {
    $("#site_content").load('/Listing/Edit/' + id).show("slow");
}

//____________________END LISTINGS_________________________________________________
>>>>>>> Create Listings
