$(document).ready(function () {
    $("#site_content2").hide("slow");
});

function Cancel(id) {
    $("#site_content").hide("slow").load('/Search/MyNewSearch').show("slow");;
}