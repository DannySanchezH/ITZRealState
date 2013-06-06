$(document).ready(function () {
    $("#site_content2").hide("slow");
});

function CreateRoom() {
    $("#site_content").hide("slow").load('/Room/Create').show("slow");
}