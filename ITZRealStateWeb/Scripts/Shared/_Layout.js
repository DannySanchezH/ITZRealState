
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


function EditUserjs(id) {
    $("#site_content").hide("slow").load('/User/Edit/' + id).show("slow");
}

function CreateListing() {
    $("#site_content").hide("slow").load('/Listing/Create').show("slow");
}

function Listings() {
    $("#site_content").hide("slow").load('/Listing').show("slow");
}

function Agents() {
    $("#site_content").hide("slow").load('/User').show("slow");
}


function createListing(form) {
    if (!$(frm).valid()) { return false; }
    $.post($(frm).attr("action"), $(frm).serialize(), function (data) {
        if (data.IdListing != null) {
            $("#site_content").hide("slow");
            updateTable(data);
        } else {
            $("#site_content").hide("slow");
        }
    });
    return false;
}

function updateTable(data) {
    $('#Listing-table').dataTable().fnAddData([
		data.,
		data.lastName,
		publicColumn(data.isPublic),
		actionsColumn(data.bookId)
    ]);
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