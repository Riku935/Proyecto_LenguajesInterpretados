mergeInto(LibraryManager.library, {

  Hello: function () {
    window.alert("Hello, world!");
  },

  HelloString: function (str) {
    window.alert(UTF8ToString(str));
  },

  PrintFloatArray: function (array, size) {
    for(var i = 0; i < size; i++)
    console.log(HEAPF32[(array >> 2) + i]);
  },

  AddNumbers: function (x, y) {
    return x + y;
  },

  StringReturnValueFunction: function () {
    var returnStr = "bla";
    var bufferSize = lengthBytesUTF8(returnStr) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(returnStr, buffer, bufferSize);
    return buffer;
  },

  BindWebGLTexture: function (texture) {
    GLctx.bindTexture(GLctx.TEXTURE_2D, GL.textures[texture]);
  },

  Usuario: function(user, pass){
    var username = prompt ("Ingresa tu nombre de usuario");
    console.log(UTF8ToString(user));
    console.log(UTF8ToString(pass));


        var xmlHttp = new XMLHttpRequest();
        var theUrl = "Conexion.php?user=" + UTF8ToString(user)+"&password="UTF8ToString(pass);
        xmlHttp.open( "GET", theUrl, false ); // false for synchronous request
        xmlHttp.send( null );
        var returnStr = xmlHttp.responseText;
        console.log("res " + returnStr);

        var bufferSize = lengthBytesUTF8(returnStr) + 1;
        var buffer = _malloc(bufferSize);
        stringToUTF8(returnStr, buffer, bufferSize);
        return buffer;


  },
  UsuarioLogin: function(userLog, passLog){
    var username = prompt ("Ingresa tu nombre de usuario");
    console.log(UTF8ToString(userLog));
    console.log(UTF8ToString(passLog));

    var returnStr = "bla";
    var bufferSize = lengthBytesUTF8(returnStr) + 1;
    var buffer = _malloc(bufferSize);
    stringToUTF8(returnStr, buffer, bufferSize);
    return buffer;
  }



});
