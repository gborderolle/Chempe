/*Dashboard Init*/
"use strict";
/*DataTable Init*/

// -------------------------------------------------------------------

if ($("#datable_1").length > 0) {
    /*Checkbox Add*/
    var tdCnt = 0;
    $('#datable_1 tr').each(function() {
        $('<span class="form-check mb-0"><input type="checkbox" class="form-check-input check-select" id="chk_sel_' + tdCnt + '"><label class="form-check-label" for="chk_sel_' + tdCnt + '"></label></span>').appendTo($(this).find("td:first-child"));
        tdCnt++;
    });
    var targetDt1 = $('#datable_1').DataTable({
        "dom": '<"row"<"col-7 mb-3"<"contact-toolbar-left">><"col-5 mb-3"<"contact-toolbar-right"f>>><"row"<"col-sm-12"t>><"row"<"col-sm-12 col-md-5"i><"col-sm-12 col-md-7"p>>',
        "ordering": true,
        "columnDefs": [{
            "searchable": false,
            "orderable": false,
            "targets": [0, 5]
        }],
        "order": [1, 'asc'],
        language: {
            search: "",
            searchPlaceholder: "Search",
            "info": "_START_ - _END_ of _TOTAL_",
            sLengthMenu: "View  _MENU_",
            paginate: {
                next: '<i class="ri-arrow-right-s-line"></i>', // or '→'
                previous: '<i class="ri-arrow-left-s-line"></i>' // or '←' 
            }
        },
        "drawCallback": function() {
            $('.dataTables_paginate > .pagination').addClass('custom-pagination pagination-simple pagination-sm');
        }
    });
    $(document).on('click', '.del-button', function() {
        targetDt1.rows('.selected').remove().draw(false);
        return false;
    });
    $("#datable_1_wrapper .contact-toolbar-left").html('<div class="d-xxl-flex d-none align-items-center"><div class="btn-group btn-group-sm" role="group" aria-label="Basic outlined example"><button type="button" class="btn btn-outline-light active">View all</button><button type="button" class="btn btn-outline-light">Monitored</button><button type="button" class="btn btn-outline-light">Unmonitored</button></div>');
    $("#datable_1_wrapper .contact-toolbar-right").addClass('d-flex justify-content-end').append('	<button class="btn btn-sm btn-outline-light ms-3"><span><span class="icon"><i class="bi bi-filter"></i></span><span class="btn-text">Filters</span></span></button>');
    $("#datable_1").parent().addClass('table-responsive');

    /*Select all using checkbox*/
    var DT1 = $('#datable_1').DataTable();
    $("#customCheck1").on("click", function(e) {
        $('#datable_1 tr .check-select').attr('checked', true);
        if ($(this).is(":checked")) {
            DT1.rows().select();
            $('#datable_1 tr .check-select').prop('checked', true);
        } else {
            DT1.rows().deselect();
            $('#datable_1 tr .check-select').prop('checked', false);
        }
    });
    $("#datable_1 tr .check-select").on("click", function(e) {
        if ($(this).is(":checked")) {
            $(this).closest('tr').addClass('selected');
        } else {
            $(this).closest('tr').removeClass('selected');
            $("#customCheck1").prop('checked', false);
        }
    });
}


// -------------------------------------------------------------------


if ($("#datable_2").length > 0) {
    /*Checkbox Add*/
    var tdCnt = 0;
    $('#datable_2 tr').each(function() {
        $('<span class="form-check mb-0"><input type="checkbox" class="form-check-input check-select" id="chk_sel_' + tdCnt + '"><label class="form-check-label" for="chk_sel_' + tdCnt + '"></label></span>').appendTo($(this).find("td:first-child"));
        tdCnt++;
    });
    var targetDt2 = $('#datable_2').DataTable({
        "dom": '<"row"<"col-7 mb-3"<"contact-toolbar-left">><"col-5 mb-3"<"contact-toolbar-right"f>>><"row"<"col-sm-12"t>><"row"<"col-sm-12 col-md-5"i><"col-sm-12 col-md-7"p>>',
        "ordering": true,
        "columnDefs": [{
            "searchable": false,
            "orderable": false,
            "targets": [0, 5]
        }],
        "order": [1, 'asc'],
        language: {
            search: "",
            searchPlaceholder: "Search",
            "info": "_START_ - _END_ of _TOTAL_",
            sLengthMenu: "View  _MENU_",
            paginate: {
                next: '<i class="ri-arrow-right-s-line"></i>', // or '→'
                previous: '<i class="ri-arrow-left-s-line"></i>' // or '←' 
            }
        },
        "drawCallback": function() {
            $('.dataTables_paginate > .pagination').addClass('custom-pagination pagination-simple pagination-sm');
        }
    });
    $(document).on('click', '.del-button', function() {
        targetDt2.rows('.selected').remove().draw(false);
        return false;
    });
    $("#datable_2_wrapper .contact-toolbar-left").html('<div class="d-xxl-flex d-none align-items-center"><div class="btn-group btn-group-sm" role="group" aria-label="Basic outlined example"><button type="button" class="btn btn-outline-light active">View all</button><button type="button" class="btn btn-outline-light">Monitored</button><button type="button" class="btn btn-outline-light">Unmonitored</button></div>');
    $("#datable_2_wrapper .contact-toolbar-right").addClass('d-flex justify-content-end').append('	<button class="btn btn-sm btn-outline-light ms-3"><span><span class="icon"><i class="bi bi-filter"></i></span><span class="btn-text">Filters</span></span></button>');
    $("#datable_2").parent().addClass('table-responsive');

    /*Select all using checkbox*/
    var DT2 = $('#datable_2').DataTable();
    $("#customCheck2").on("click", function(e) {
        $('#datable_2 tr .check-select').attr('checked', true);
        if ($(this).is(":checked")) {
            DT2.rows().select();
            $('#datable_2 tr .check-select').prop('checked', true);
        } else {
            DT2.rows().deselect();
            $('#datable_2 tr .check-select').prop('checked', false);
        }
    });
    $("#datable_2 tr .check-select").on("click", function(e) {
        if ($(this).is(":checked")) {
            $(this).closest('tr').addClass('selected');
        } else {
            $(this).closest('tr').removeClass('selected');
            $("#customCheck2").prop('checked', false);
        }
    });
}


// -------------------------------------------------------------------