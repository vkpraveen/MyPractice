/**
 * Created by Praveen Kumar V on 7/3/2016.
 */
'use strict';
define(["jquery","data/getValues","data/setValues"],function($,getValues,setValues){
    var results = '';

    var add = function () {
        results = getValues.num1 + getValues.num2;
       // results = $('#txtnum1').val() + $('#txtnum1').val();
        setValues.set(results);
    };

    var sub = function () {
        results = getValues.num1 - getValues.num2;
        setValues.set(results);
    };
    var mul = function () {
        results = getValues.num1 * getValues.num2;
        setValues.set(results);
    };
    var div = function () {
        results = getValues.num1 / getValues.num2;
        setValues.set(results);
    };

    /* register event handlers */

    function _registerEventHandlers() {
        $("#btnAdd").on("click", add);
        $("#btnSub").on("click", sub);
        $("#btnMul").on("click", mul);
        $("#btnDiv").on("click", div);
    }

    return{
        init:function(){
            _registerEventHandlers();
        }
    }
});