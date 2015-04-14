// delete list
$(document.documentElement).on("click", ".board-deletelist", function (e) {
	var list = $parentContextData(this, null, null, List);
	var lists = list.get_User().get_Lists();
	var idx = lists.indexOf(list);
	lists.remove(list);
	for (var i = idx; i < lists.length; i++) {
		lists[i].set_Sequence(idx);
	}
	e.stopPropagation();
});
