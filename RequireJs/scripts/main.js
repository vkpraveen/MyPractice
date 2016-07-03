/**
 * Created by Praveen Kumar V on 7/3/2016.
 */
'use strict';
require.config({
    paths: {
        jquery: "jquery-3.0.0.min"
    }
});
require(["app"], function (app) {
app.init();
});