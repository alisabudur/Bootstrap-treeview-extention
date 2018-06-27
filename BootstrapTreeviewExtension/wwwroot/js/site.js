var AdditionalActions = (function () {
    var addStudent = function (e) {
        alert('addStudent for teacher id = ' + e.data.params.teacherId + ' and name = ' + e.data.params.name);
    };

    var removeStudent = function (e) {
        alert('removeStudent for teacher id = ' + e.data.params.teacherId);
    };

    var studentDetails = function (e) {
        alert('studentDetails for student id = ' + e.data.params.studentId);
    };

    var gradeDetails = function (e) {
        alert('gradeDetails for grade id = ' + e.data.params.gradeId);
    };

    return {
        addStudent: addStudent,
        removeStudent: removeStudent,
        studentDetails: studentDetails,
        gradeDetails: gradeDetails
    };
}());

var Site = (function () {
    var additionalActions = [
        {
            level: 1,
            actions: [
                {
                    templateId: 'remove-student',
                    event: 'click',
                    handler: AdditionalActions.removeStudent
                },
                {
                    templateId: 'add-student',
                    event: 'click',
                    handler: AdditionalActions.addStudent
                }
            ]
        },
        {
            level: 2,
            actions: [
                {
                    templateId: 'student-details',
                    event: 'click',
                    handler: AdditionalActions.studentDetails
                }
            ]
        },
        {
            level: 3,
            actions: [
                {
                    templateId: 'grade-details',
                    event: 'click',
                    handler: AdditionalActions.gradeDetails
                }
            ]
        }
    ];

    var renderTree = function(data) {
        $('#tree').treeview({
            data: data,
            additionalActions: additionalActions
        });
    };

    var getTreeItems = function () {
        $.get('http://localhost:50027/Home/GetTreeItems', renderTree);
    };

    return {
        getTreeItems: getTreeItems
    };
}());

$(document).ready(function() {
    Site.getTreeItems();
});