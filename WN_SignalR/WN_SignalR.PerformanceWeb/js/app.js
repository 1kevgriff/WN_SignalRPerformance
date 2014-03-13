function createCanvas() {
    var c = document.getElementById("heatMap");
    var context = c.getContext("2d");

    return context;
}

function incrementPixel(canvasContext, x, y, sendToClients) {
    if (!canvasContext) {
        canvasContext = context;
    }

    var imageData = canvasContext.getImageData(x - 2, y - 2, 11, 11);
    var pixels = imageData.data;
    for (var loop = 0; loop < (121 * 4) ; loop = loop + 4) {
        pixelData.data[loop] = pixels[loop] + 1; // up the RED
        pixelData.data[loop + 3] = 255; // SHOW IT
    }

    canvasContext.putImageData(pixelData, x - 5, y - 5);

    if (sendToClients) {
        hub.server.move({
            x: x,
            y: y
        });
    }
}

var context = createCanvas();
var pixelData = context.createImageData(5, 5);

$("#heatMap").on("mousemove", function (event) {
    //console.log("mouse at page: (" + event.pageX + ", " + event.pageY + ") client: (" + event.clientX + ", " + event.clientY + ") offset: (" + event.offsetX + ", " + event.offsetY + ")");
    incrementPixel(context, event.offsetX, event.offsetY, true);
});

var hub = $.connection.mouseHub;
hub.client.registerMovement = function (movement) {
    incrementPixel(context, movement.x, movement.y, false);
};

$.connection.hub.start();