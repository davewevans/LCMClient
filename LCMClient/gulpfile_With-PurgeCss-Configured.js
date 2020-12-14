const gulp = require('gulp');
const purgecss = require('gulp-purgecss')

gulp.task('css', () => {
    const postcss = require('gulp-postcss');

    return gulp.src('./Styles/site.css')
        .pipe(postcss([
            require('precss'),
            require('tailwindcss'),
            require('autoprefixer')
        ]))
        .pipe(purgecss({ content: ['**/*.html', '**/*.razor'] }))
        .pipe(gulp.dest('./wwwroot/css/'));
});