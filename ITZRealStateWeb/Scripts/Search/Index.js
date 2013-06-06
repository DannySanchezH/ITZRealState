function submitform(frm) {
    if (!$(frm).valid()) { return false; }
    $.post($(frm).attr("action"), $(frm).serialize(), function (data) {
        if (data.zipcode != null) {

        } else {
            $("#site-content").hide("slow");
        }
    });
    return false;
}