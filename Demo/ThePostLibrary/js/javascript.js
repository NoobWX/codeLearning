//1.翻转海报
function turn(elem) {
    var cls = elem.className;
    var n = elem.id.split('_')[1];
    if (!/photo_center/.test(cls)) {
        return rsort(n);
    }
    if (/photo_front/.test(cls)) {
        cls = cls.replace(/photo_front/, 'photo_back');
        g('#nav_' + n).className += ' i_back ';
    } else {
        cls = cls.replace(/photo_back/, 'photo_front');
        g('#nav_' + n).className = g('#nav_' + n).className.replace(/i_back\s*/, ' ');
    }
    return elem.className = cls;
}

// 通用函数,选择相应获取方法

function g(selector) {
    var method = selector.substr(0, 1) == '.' ? 'getElementsByClassName' : 'getElementById';
    return document[method](selector.substr(1));
}

// 输出所有的海报
var data = data;
function addPhoto() {

    var template = g('#wrap').innerHTML;
    var html = [];
    var nav = [];
    for (s in data) {
        var _html = template
            .replace('{{index}}', s)
            .replace('{{img}}', data[s].img)
            .replace('{{caption}}', data[s].caption)
            .replace('{{desc}}', data[s].desc);
        html.push(_html);
        nav.push('<span id="nav_' + s + '" class="i" onclick="turn(g(\'#photo_' + s + '\'))">&nbsp</span>');
    }
    html.push('<div class="nav">' + nav.join('') + '</div>');
    g('#wrap').innerHTML = html.join('');
    var array = [1, data.length - 1];
    rsort(random(array));
    // console.log(array[1]);
}
addPhoto();

// 排序海报
function rsort(n) {

    var _photo = g('.photo');
    var photos = [];
    for (s = 0; s < _photo.length; s++) {
        _photo[s].className = _photo[s].className.replace(/\s*photo_center\s*/, '');
        _photo[s].className = _photo[s].className.replace(/\s*photo_front\s*/, '');
        _photo[s].className = _photo[s].className.replace(/\s*photo_back\s*/, '');
        _photo[s].className += ' photo_front';
        _photo[s].style.left = '';
        _photo[s].style.top = '';
        _photo[s].style['transform'] = 'rotate(360deg) scale(1.3)';

        photos.push(_photo[s]);
    }

    var photo_center = g('#photo_' + n);
    photo_center.className += ' photo_center';
    photo_center = photos.splice(n, 1)[0];
    console.log(photos.length);

    //将海报分成左右两个部分
    var photos_left = photos.splice(0, Math.ceil(photos.length / 2));
    var photos_right = photos;

    var ranges = range();
    // console.log(photos_left.length,photos_right.length);
    for (s in photos_right) {
        var photo = photos_right[s];
        photo.style.left = random(ranges.right.x) + 'px';
        photo.style.top = random(ranges.right.y) + 'px';
        photo.style['transform'] = 'rotate(' + random([-150, 150]) + 'deg) scale(1)';
    }
    for (s in photos_left) {
        var photo = photos_left[s];
        photo.style.left = random(ranges.left.x) + 'px';
        photo.style.top = random(ranges.left.y) + 'px';
        photo.style['transform'] = 'rotate(' + random([-150, 150]) + 'deg) scale(1)';

    }
    //控制按钮处理
    var navs = g('.i');
    for (var s = 0; s < navs.length; s++) {
        navs[s].className = navs[s].className.replace(/i_current\s*/, ' ');
        navs[s].className = navs[s].className.replace(/i_back\s*/, ' ');

    }
    g('#nav_' + n).className += ' i_current ';
}

function range() {
    var range = { left: { x: [], y: [] }, right: { x: [], y: [] } }
    var wrap = {
        w: g('#wrap').clientWidth,
        h: g('#wrap').clientHeight
    }
    var photo = {
        w: g('.photo')[0].clientWidth,
        h: g('.photo')[0].clientHeight
    }
    // console.log(wrap,photo);
    range.wrap = wrap;
    range.photo = photo;
    range.left.x = [0 - photo.w, wrap.w / 2 - photo.w / 2];
    range.left.y = [0 - photo.h, wrap.h];
    range.right.x = [wrap.w / 2 + photo.w / 2, wrap.w + photo.w];
    range.right.y = [0 - photo.h, wrap.h];
    return range;
}

// 随机生成一个值 支持取值范围 random([min.max])
function random(range) {
    var max = Math.max(range[0], range[1]);
    var min = Math.min(range[0], range[1]);
    var diff = max - min;
    var number = Math.ceil(Math.random() * diff + min);
    console.log(number);
    return number;
}