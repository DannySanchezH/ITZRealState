﻿function ActivateFields(){
    $("#AgentField").show("slow");
}

function CreateAgent() {
    $("#site_content").hide("slow").load('/User/Create').show("slow");
}

function createAgent(form) {
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

function editAgent(id) {
    $("#site_content").hide("slow").load('/User/Edit/' + id).show("slow");
}

function cancel() {
    $("#site_content").hide("slow").load('/User/').show("slow");
}