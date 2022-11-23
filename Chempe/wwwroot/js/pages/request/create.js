/*
DTO_New_request

    model.List_DTO_List_warrants_type

*/

$(function () {
    //var panel_tv = $(".panel_tv");
    //if (panel_tv !== null && panel_tv !== undefined) {
    //    panel_tv.show();
    //}
});

function ddl_warrant_type_onChange() {
    var ddl_warrant_type = $("#Warrant_type_ID :selected").text();
    var panel = $(".panel");

    // hide all panels
    if (ddl_warrant_type !== null && ddl_warrant_type !== undefined &&
        panel !== null && panel !== undefined) {
        panel.hide();

        // TV
        ddl_warrant_type = $.trim(ddl_warrant_type);
        if (ddl_warrant_type == "Televisor") {
            var panel_tv = $(".panel_tv");
            if (panel_tv !== null && panel_tv !== undefined) {
                panel_tv.show();
            }
        }

        /*
        var List_DTO_List_warrants_type = model.List_DTO_List_warrants_type;
        if (List_DTO_List_warrants_type !== null && List_DTO_List_warrants_type !== undefined) {
        }
        */
    }
}
