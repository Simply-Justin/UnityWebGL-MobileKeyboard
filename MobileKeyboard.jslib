mergeInto(LibraryManager.library, {
    OpenTextPromt: function(_name, _str, _promptText){
        if(/iPhone|iPad|iPod|Android/i.test(navigator.userAgent)){
            var _inputTextData = prompt(Pointer_stringify(_promptText), Pointer_stringify(_str));
            if (_inputTextData == null || _inputTextData == "") {
                //canceled text
            } else {
                //send data to unity
                SendMessage(Pointer_stringify(_name), 'ReceiveInputData', _inputTextData);
            }  
        }
    },
});
