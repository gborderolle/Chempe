/******** Auxiliar Functions ********/

// Variable object types
var TYPES = {
    'undefined': 'undefined',
    'number': 'number',
    'boolean': 'boolean',
    'string': 'string',
    '[object Function]': 'function',
    '[object RegExp]': 'regexp',
    '[object Array]': 'array',
    '[object Date]': 'date',
    '[object Error]': 'error'
},
 TOSTRING = Object.prototype.toString;


$(function () {
    $(".datepicker").datepicker({ dateFormat: 'dd/mm/yy' });
});

// Get variable object type
function type(o) {
    return TYPES[typeof o] || TYPES[TOSTRING.call(o)] || (o ? 'object' : 'null');
};

function TryParseInt(str, defaultValue) {
    var retValue = defaultValue;
    if (str !== null) {
        if (str.length > 0) {
            if (!isNaN(str)) {
                retValue = parseInt(str);
            }
        }
    }
    return retValue;
}

function TryParseFloat(str, defaultValue) {
    var retValue = defaultValue;
    if (str !== null) {
        if (str.length > 0) {
            str = str.replace(',', '.');
            if (!isNaN(str)) {
                retValue = parseFloat(str);
            }
        }
    }
    return retValue;
}

function show_message_confirm(msg) {
    $('#dialog p').text(hashMessages[msg]);
    $("#dialog").dialog({
        open: {},
        resizable: false,
        height: 150,
        modal: true,
        buttons: {
            "Confirmar": function () {
                $(this).dialog("close");
                return true;

            },
            "Cancelar": function () {
                $(this).dialog("close");
                return false;
            }
        }
    });
}

function show_message_info(msg) {
    $('#dialog p').text(hashMessages[msg]);
    $("#dialog").dialog({
        open: {},
        resizable: false,
        height: 150,
        modal: true,
        buttons: {
            "Aceptar": function () {
                $(this).dialog("close");
                return true;
            }
        }
    });
}

function roundUp(number, precision) {
    Math.ceil(number * precision) / precision;
}

function numberWithCommas(x) {
    return x.toString().replace(/\B(?=(\d{3})+(?!\d))/g, ",");
}

function numberRemoveCommas(x) {
    return parseFloat(x.replace(/,/g, ''));
}

function arrayRemoveByID(array, value) {
    return array.filter(function (obj) { return obj.lblElementoID !== lblElementoID; });
}

function zero_or_isNaN(str) {
    return_value = 0;
    if (!isNaN(str)) {
        return_value = str;
    }
    return return_value;
}


function check_zeros(value) {
    return value.replace(/0/g, "");
} 

function convertBool(value) {
    var ret = "No";
    if (value) {
        ret = "Si";
    }
    return ret;
}

function check_nullValues(value) {
    var value_return = value;
    if (value === null || value === undefined) {
        value_return = "";
    }
    return value_return;
}

function isMobile() {
    let check = false;
    (function (a) { if (/(android|bb\d+|meego).+mobile|avantgo|bada\/|blackberry|blazer|compal|elaine|fennec|hiptop|iemobile|ip(hone|od)|iris|kindle|lge |maemo|midp|mmp|mobile.+firefox|netfront|opera m(ob|in)i|palm( os)?|phone|p(ixi|re)\/|plucker|pocket|psp|series(4|6)0|symbian|treo|up\.(browser|link)|vodafone|wap|windows ce|xda|xiino/i.test(a) || /1207|6310|6590|3gso|4thp|50[1-6]i|770s|802s|a wa|abac|ac(er|oo|s\-)|ai(ko|rn)|al(av|ca|co)|amoi|an(ex|ny|yw)|aptu|ar(ch|go)|as(te|us)|attw|au(di|\-m|r |s )|avan|be(ck|ll|nq)|bi(lb|rd)|bl(ac|az)|br(e|v)w|bumb|bw\-(n|u)|c55\/|capi|ccwa|cdm\-|cell|chtm|cldc|cmd\-|co(mp|nd)|craw|da(it|ll|ng)|dbte|dc\-s|devi|dica|dmob|do(c|p)o|ds(12|\-d)|el(49|ai)|em(l2|ul)|er(ic|k0)|esl8|ez([4-7]0|os|wa|ze)|fetc|fly(\-|_)|g1 u|g560|gene|gf\-5|g\-mo|go(\.w|od)|gr(ad|un)|haie|hcit|hd\-(m|p|t)|hei\-|hi(pt|ta)|hp( i|ip)|hs\-c|ht(c(\-| |_|a|g|p|s|t)|tp)|hu(aw|tc)|i\-(20|go|ma)|i230|iac( |\-|\/)|ibro|idea|ig01|ikom|im1k|inno|ipaq|iris|ja(t|v)a|jbro|jemu|jigs|kddi|keji|kgt( |\/)|klon|kpt |kwc\-|kyo(c|k)|le(no|xi)|lg( g|\/(k|l|u)|50|54|\-[a-w])|libw|lynx|m1\-w|m3ga|m50\/|ma(te|ui|xo)|mc(01|21|ca)|m\-cr|me(rc|ri)|mi(o8|oa|ts)|mmef|mo(01|02|bi|de|do|t(\-| |o|v)|zz)|mt(50|p1|v )|mwbp|mywa|n10[0-2]|n20[2-3]|n30(0|2)|n50(0|2|5)|n7(0(0|1)|10)|ne((c|m)\-|on|tf|wf|wg|wt)|nok(6|i)|nzph|o2im|op(ti|wv)|oran|owg1|p800|pan(a|d|t)|pdxg|pg(13|\-([1-8]|c))|phil|pire|pl(ay|uc)|pn\-2|po(ck|rt|se)|prox|psio|pt\-g|qa\-a|qc(07|12|21|32|60|\-[2-7]|i\-)|qtek|r380|r600|raks|rim9|ro(ve|zo)|s55\/|sa(ge|ma|mm|ms|ny|va)|sc(01|h\-|oo|p\-)|sdk\/|se(c(\-|0|1)|47|mc|nd|ri)|sgh\-|shar|sie(\-|m)|sk\-0|sl(45|id)|sm(al|ar|b3|it|t5)|so(ft|ny)|sp(01|h\-|v\-|v )|sy(01|mb)|t2(18|50)|t6(00|10|18)|ta(gt|lk)|tcl\-|tdg\-|tel(i|m)|tim\-|t\-mo|to(pl|sh)|ts(70|m\-|m3|m5)|tx\-9|up(\.b|g1|si)|utst|v400|v750|veri|vi(rg|te)|vk(40|5[0-3]|\-v)|vm40|voda|vulc|vx(52|53|60|61|70|80|81|83|85|98)|w3c(\-| )|webc|whit|wi(g |nc|nw)|wmlb|wonu|x700|yas\-|your|zeto|zte\-/i.test(a.substr(0, 4))) check = true; })(navigator.userAgent || navigator.vendor || window.opera);
    return check;
}

function split(val) {
    return val.split(/,\s*/);
}

function extractLast(term) {
    return split(term).pop();
}

//Manejo de cookie local
function getCookie(cookieName) {
    const name = cookieName + "=";
    const cDecoded = decodeURIComponent(document.cookie); //to be careful
    const cArr = cDecoded.split('; ');
    let res;
    cArr.forEach(val => {
        if (val.indexOf(name) === 0) res = val.substring(name.length);
    })
    console.log("get cookies result:" + res);
    return res;
}

function setCookie(cookieName, value) {
    document.cookie = cookieName + "=" + value + "; expires=Thu, 31 Dec 2099 23:59:59 GMT; path=/";
    let cookies = document.cookie;
    console.log("set cookies result:" + cookies);
}
//

function show_alert_alert() {
    // Source: https://sweetalert.js.org/
    // Source: https://www.jquery-az.com/javascript/demo.php?ex=151.0_5
    swal({
        title: "Your account will be deleted permanently!",
        text: "Are you sure to proceed?",
        type: "warning",
        showCancelButton: true,
        confirmButtonColor: "#DD6B55",
        confirmButtonText: "Remove My Account!",
        cancelButtonText: "I am not sure!",
        closeOnConfirm: false,
        closeOnCancel: false
    },
        function (isConfirm) {
            if (isConfirm) {
                swal("Account Removed!", "Your account is removed permanently!", "success");
            }
            else {
                swal("Hurray", "Account is not removed!", "error");
            }
        });
}

function show_alert_success(text, subtext) {
    swal({
        title: text,
        text: subtext,
        type: "success",
        //confirmButtonColor: "#0aa00a",#6c757d
        confirmButtonColor: "#6c757d",
        confirmButtonText: "Cerrar",
        closeOnConfirm: true,
        customClass: 'swal-wide'
    });
}

function show_alert_error(text) {
    swal({
        title: text,
        type: "error",
        confirmButtonColor: "red",
        confirmButtonText: "Cerrar",
        closeOnConfirm: true
    });
}