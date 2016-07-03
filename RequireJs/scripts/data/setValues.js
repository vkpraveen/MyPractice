/**
 * Created by Praveen Kumar V on 7/3/2016.
 */
'use strict';
define(["jquery"],function($){
    var _set = function (results) {
        $('#divtext').text(results);
    };
    return{
        set:function(results){
            _set(results);
        }
    }
});