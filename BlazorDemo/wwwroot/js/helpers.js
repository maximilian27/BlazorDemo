// in order to add custom javascript functionality which can be later used in blazor
// the new methods need to be added directly to the window object

window.deleteTodo = (list, index) => {
    list.splice(index, 1);
    console.log('updated list', list);
    return list;
}

window.mouseoverHandler = (elem) => {
    console.log('hovered element: ', elem);
    if (elem) {
        elem.style.background = '#eee'
    }
}