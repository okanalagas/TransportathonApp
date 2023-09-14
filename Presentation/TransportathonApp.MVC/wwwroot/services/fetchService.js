async function fetchService(url, prm, fallBack) {

    $("#_pblloading").show();
    $(".site_loading").show();

    const response = await fetch(url, {
        method: "POST",
        headers: {
            "Content-type": "application/json"
        },
        body: JSON.stringify(prm)        
    });

    $("#_pblloading").hide();
    $(".site_loading").hide();
    if (response.status != 200) {
        swal({
            title: "Ooops!",
            text: "Beklenmeyen Hata!",
            type: "error"
        });
        return;
    }

    var serviceResult = await response.json();

    if (serviceResult.isSuccessful == false) {
        swal({
            title: "Ooops!",
            text: "Beklenmeyen Hata",
            type: "error"
        });
        if (fallBack)
            fallBack();
        return;
    }
    return serviceResult;
}