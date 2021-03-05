// send an event via naoqi
function sendRequest(eventName, eventParams) {
    console.log(eventName + " " + eventParams);
    session.service('ALMemory').done(function (ALMemory) {
		ALMemory.raiseEvent(eventName, eventParams);
    });
}

// deactivate all buttons and send the given answer to the interaction-manager.
function sendAnswer(eventParams, object) {
    if (buttons_active) {
        last_button_clicked = object;     

        // get time of the answer
        c_time = Date.now();

        // send the answer
        sendRequest('answer', eventParams);

        // calculate the length of the run and send the time to python
        overall_time = c_time - start_time;
        sendRequest('answer_time', overall_time);

        buttons_active = false;
        //$('#text').css("visibility", "hidden");
        for (var i=0; i<4; ++i) {
            $('#div_' + i).attr("class", "image_container");
        }
    }
}

// send an event to stop all running tts-things on the robot
function stopTTS() {
    sendRequest("dialog_stop", "");
}

// let the system sleep some time
function sleep(time) {
    return new Promise((resolve) => setTimeout(resolve, time));
}