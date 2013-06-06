$(document).ready(function () {
    $("#site_content2").hide("slow");
});
function CreateAmenitie() {
    $("#site_content").hide("slow").load('/Amenitie/Create').show("slow");
}