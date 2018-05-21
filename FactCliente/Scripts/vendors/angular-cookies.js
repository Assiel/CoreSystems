/**
 * @license AngularJS v1.6.0
 * (c) 2010-2016 Google, Inc. http://angularjs.org
 * License: MIT
 */
(function (m, f) {
    function k(a, b, c) {
        var d = c.baseHref(), l = a[0]; return function (a, g, e) {
            e = e || {}; var c = e.expires; var h = f.isDefined(e.path) ? e.path : d; f.isUndefined(g) && (c = "Thu, 01 Jan 1970 00:00:00 GMT", g = ""); f.isString(c) && (c = new Date(c)); g = encodeURIComponent(a) + "=" + encodeURIComponent(g); g = g + (h ? ";path=" + h : "") + (e.domain ? ";domain=" + e.domain : ""); g += c ? ";expires=" + c.toUTCString() : ""; g += e.secure ? ";secure" : ""; e = g.length + 1; 4096 < e && b.warn("Cookie '" + a + "' possibly not set or overflowed because it was too large (" +
            e + " > 4096 bytes)!"); l.cookie = g
        }
    } f.module("ngCookies", ["ng"]).provider("$cookies", [function () { var a = this.defaults = {}; this.$get = ["$$cookieReader", "$$cookieWriter", function (b, c) { return { get: function (d) { return b()[d] }, getObject: function (d) { return (d = this.get(d)) ? f.fromJson(d) : d }, getAll: function () { return b() }, put: function (d, b, h) { c(d, b, h ? f.extend({}, a, h) : a) }, putObject: function (d, a, c) { this.put(d, f.toJson(a), c) }, remove: function (d, b) { c(d, void 0, b ? f.extend({}, a, b) : a) } } }] }]); f.module("ngCookies").factory("$cookieStore",
    ["$cookies", function (a) { return { get: function (b) { return a.getObject(b) }, put: function (b, c) { a.putObject(b, c) }, remove: function (b) { a.remove(b) } } }]); k.$inject = ["$document", "$log", "$browser"]; f.module("ngCookies").provider("$$cookieWriter", function () { this.$get = k })
})(window, window.angular);