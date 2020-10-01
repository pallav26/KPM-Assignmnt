sendFlowRequest = function () {
    var pathObj = { "path": "/Account/" };

    parent.$.ajax({
        type: "POST",
        url: "https://prod-30.centralindia.logic.azure.com:443/workflows/f41f799db6734f488f1fad0de896e26e/triggers/manual/paths/invoke?api-version=2016-06-01&sp=%2Ftriggers%2Fmanual%2Frun&sv=1.0&sig=KjKdGXJQuWgyJXUF2zdryblFUC7Bt6IiULULqFx8aAY",
        contentType: 'application/json',
        data: JSON.stringify(pathObj),
        success: function () {
            alert("success");
        }
    });
}