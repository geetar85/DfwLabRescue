var Content = function () {

    function handleRazorEditor() {
        $('.raptor').raptor({
            plugins: {
                draggable: false,
                dock: {
                    dockToElement: true
                },
                save: {
                    plugin: 'saveJson'
                },
                saveJson: {
                    url: '/api/Content',
                    postName: 'raptorContent',
                    id: function () {
                        return this.raptor.getElement().data('id');
                    }
                }
            },
            bind: {
                layoutShow: function () {
                    if ($('.raptor-ui-upload-file').length == 0) {
                        var insertImageEl = $('<div data-toggle="modal" data-target=".image-upload-modal" class="raptor-ui-upload-file ui-button ui-widget ui-state-default ui-button-icon-only ui-corner-right" role="button" aria-disabled="false" data-title="Upload file"><span class="ui-button-icon-primary ui-icon ui-icon-circle-plus"></span><span class="ui-button-text"></span></div>');
                        var $element = $('.raptor-ui-insert-file');
                        $element.after(insertImageEl);
                    }
                }
            }
        });
    }

    function handleFileUpload() {
        $('#fileupload').fileupload({
            dataType: 'json',
            autoUpload: false,
            add: function (e, data) {
                data.context = $('<li/>').html('<h3>' + data.files[0].name + '</h3><div class="image-output"><div class="progress"><div class="progress-bar progress-bar-success" role="progressbar" aria-valuenow="60" aria-valuemin="0" aria-valuemax="100"><span class="sr-only">60% Complete</span></div></div></div>')
                    .appendTo('#uploaded-files');
                data.submit();
            },
            progress: function (e, data) {
                var progress = parseInt(data.loaded / data.total * 100, 10);
                data.context.find('.progress-bar').css('width', progress + '%');
                $('')
            },
            done: function (e, data) {
                $.each(data.result.files, function (index, file) {
                    setTimeout(function () {
                        data.context.find('.image-output').html('<i class="fa fa-check color-green"></i> ' + file.url + '</li>');
                    }, 2000);
                });
            }
        });
    }

    return {
        init: function (isAuthenticated) {
            if (isAuthenticated) {
                handleRazorEditor();
                handleFileUpload();
            }
        },
        

    };
}();