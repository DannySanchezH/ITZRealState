

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

        $("#site_content2").hide("slow");
    $("#site_content").hide("slow").load('/Desire/Index/' + id).show("slow");
}

function EditUserjs(id) {
    $("#site_content").hide("slow").load('/User/Edit/' + id).show("slow");
}

function CreateListing() {
    $("#site_content").hide("slow").load('/Listing/Create').show("slow");
}

function Listings() {
    $("#site_content2").hide("slow");
    $("#site_content").hide("slow").load('/Listing').show("slow");
}

function MyListings(id) {
    $("#site_content2").hide("slow");
    $("#site_content").hide("slow").load('/Listing/MyListings/' + id).show("slow");
}

function Agents() {
    $("#site_content2").hide("slow");
    $("#site_content").hide("slow").load('/User').show("slow");
}

function Amenities() {
    $("#site_content2").hide("slow");
    $("#site_content").hide("slow").load('/Amenitie').show("slow");
}

function Rooms() {
    $("#site_content2").hide("slow");
    $("#site_content").hide("slow").load('/Room').show("slow");
}

function Search(id) {
    $("#site_content").hide("slow").load('/Search/SearchLog/' + id).show("slow");
}