var gulp = require("gulp");
var jsonServer = require("gulp-json-srv");

var server = jsonServer.create({
    port: 3006 });

gulp.task("default", function(){
    return gulp.src("db.json")
        .pipe(server.pipe());
        console.log("server json działą");
});