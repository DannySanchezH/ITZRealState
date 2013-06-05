
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

<<<<<<< HEAD
=======

>>>>>>> Listings(Create,Edit,Delete)
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
>>>>>>> Listings(Create,Edit,Delete)
function EditUserjs(id) {
    $("#site_content").hide("slow").load('/User/Edit/' + id).show("slow");
}

<<<<<<< HEAD
function CreateListing() {
    $("#site_content").hide("slow").load('/Listing/Create').show("slow");
}

=======
>>>>>>> Listings(Create,Edit,Delete)
function Listings() {
    $("#site_content").hide("slow").load('/Listing').show("slow");
}

function Agents() {
<<<<<<< HEAD
    $("#site_content").hide("slow").load('/User').show("slow");
}


function createListing(form) {
    if (!$(frm).valid()) { return false; }
    $.post($(frm).attr("action"), $(frm).serialize(), function (data) {
        if (data.IdListing != null) {
            $("#site_content").hide("slow");
        } else {
            $("#site_content").hide("slow");
        }
    });
    return false;
}

function cancelListing() {
    $("#site_content").hide("slow");
}

function cancel() {
    $("#site_content").hide("slow");
}

//Edit Listing
function editListing(id) {
    $("#site_content").load('/Listing/Edit/' + id).show("slow");
}

function Amenities() {
    $("#site_content").hide("slow").load('/Amenitie').show("slow");
}

function Rooms() {
    $("#site_content").hide("slow").load('/Room').show("slow");
}
=======

    $("#site_content").load('/User').show("slow");
}
>>>>>>> Listings(Create,Edit,Delete)
