(function(){angular.module("base64",[]).constant("$base64",function(){function e(a,b){var c="ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".indexOf(a.charAt(b));if(-1==c)throw"Cannot decode base64";return c}function f(a,b){var c=a.charCodeAt(b);if(255<c)throw"INVALID_CHARACTER_ERR: DOM Exception 5";return c}return{encode:function(a){if(1!=arguments.length)throw"SyntaxError: Not enough arguments";var b,c=[];a=""+a;var e=a.length-a.length%3;if(0==a.length)return a;for(b=0;b<e;b+=3){var d=f(a,b)<<16|f(a,b+1)<<8|f(a,b+2);c.push("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".charAt(d>>18));c.push("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".charAt(d>>12&63));c.push("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".charAt(d>>6&63));c.push("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".charAt(d&63))}switch(a.length-e){case 1:d=f(a,b)<<16;c.push("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".charAt(d>>18)+"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".charAt(d>>12&63)+"==");break;case 2:d=f(a,b)<<16|f(a,b+1)<<8,c.push("ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".charAt(d>>18)+"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".charAt(d>>12&63)+"ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789+/".charAt(d>>6&63)+"=")}return c.join("")},decode:function(a){a=""+a;var b,c=a.length;if(0==c)return a;if(0!=c%4)throw"Cannot decode base64";var f=0;"="==a.charAt(c-1)&&(f=1,"="==a.charAt(c-2)&&(f=2),c-=4);var d=[];for(b=0;b<c;b+=4){var g=e(a,b)<<18|e(a,b+1)<<12|e(a,b+2)<<6|e(a,b+3);d.push(String.fromCharCode(g>>16,g>>8&255,g&255))}switch(f){case 1:g=e(a,b)<<18|e(a,b+1)<<12|e(a,b+2)<<6;d.push(String.fromCharCode(g>>16,g>>8&255));break;case 2:g=e(a,b)<<18|e(a,b+1)<<12,d.push(String.fromCharCode(g>>16))}return d.join("")}}}())})();