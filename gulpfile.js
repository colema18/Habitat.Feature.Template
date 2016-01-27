var gulp = require('gulp');
var zip = require('gulp-zip');
var config = require("./gulp-config.js")();

/*****************************
  Publish Template Zip to the Habitat.Feature.Template
*****************************/
var thesrc = ['**/*'];
var files = config.projectLocation + "/MyTemplate.vstemplate";
gulp.task('createMainZip', function () {
    return gulp.src(files)
    .pipe(zip('main_files.zip'))
    .pipe(gulp.dest('src'));
});
