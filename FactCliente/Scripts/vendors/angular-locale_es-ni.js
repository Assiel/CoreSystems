angular.module("ngLocale", [], ["$provide", function (a) {
    a.value("$locale", {
        DATETIME_FORMATS: {
            AMPMS: ["a.m.", "p.m."], DAY: "domingo lunes martes mi\u00e9rcoles jueves viernes s\u00e1bado".split(" "), ERANAMES: ["antes de Cristo", "despu\u00e9s de Cristo"], ERAS: ["a. C.", "d. C."], FIRSTDAYOFWEEK: 6, MONTH: "enero febrero marzo abril mayo junio julio agosto septiembre octubre noviembre diciembre".split(" "), SHORTDAY: "dom. lun. mar. mi\u00e9. jue. vie. s\u00e1b.".split(" "), SHORTMONTH: "ene. feb. mar. abr. may. jun. jul. ago. sep. oct. nov. dic.".split(" "),
            STANDALONEMONTH: "enero febrero marzo abril mayo junio julio agosto septiembre octubre noviembre diciembre".split(" "), WEEKENDRANGE: [5, 6], fullDate: "EEEE, d 'de' MMMM 'de' y", longDate: "d 'de' MMMM 'de' y", medium: "d MMM y HH:mm:ss", mediumDate: "d MMM y", mediumTime: "HH:mm:ss", "short": "d/M/yy HH:mm", shortDate: "d/M/yy", shortTime: "HH:mm"
        }, NUMBER_FORMATS: {
            CURRENCY_SYM: "C$", DECIMAL_SEP: ".", GROUP_SEP: ",", PATTERNS: [{ gSize: 3, lgSize: 3, maxFrac: 3, minFrac: 0, minInt: 1, negPre: "-", negSuf: "", posPre: "", posSuf: "" }, {
                gSize: 3,
                lgSize: 3, maxFrac: 2, minFrac: 2, minInt: 1, negPre: "-\u00a4", negSuf: "", posPre: "\u00a4", posSuf: ""
            }]
        }, id: "es-ni", localeID: "es_NI", pluralCat: function (a, b) { return 1 == a ? "one" : "other" }
    })
}]);