/// <binding BeforeBuild='series' />
"use strict";

/*
This file is the main entry point for defining Gulp tasks and using Gulp plugins.
Click here to learn more. https://go.microsoft.com/fwlink/?LinkId=518007
*/

// Introduction to using Gulp in ASP.NET Core
// https://docs.microsoft.com/en-us/aspnet/core/client-side/using-gulp
// Sass
// https://docs.microsoft.com/en-us/aspnet/core/client-side/less-sass-fa#sass
var gulp = require('gulp'),
    sass = require('gulp-sass'),
    concat = require("gulp-concat"),
    cssmin = require("gulp-cssmin");

gulp.task('default', function () {
    // place code for your default task here
});

gulp.task('site.css', function () {
    return gulp.src('Styles/site.scss')
        .pipe(sass())
        .pipe(gulp.dest('wwwroot/css'));
});

gulp.task('min:css', ['site.css'], function () {
    return gulp.src('wwwroot/css/site.css')
        .pipe(concat('wwwroot/css/site.min.css'))
        .pipe(cssmin())
        .pipe(gulp.dest('.'));
});

gulp.task("series", ['site.css', 'min:css'], function () { });
