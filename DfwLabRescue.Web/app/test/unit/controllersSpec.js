'use strict';

describe('DfwLabRescue controllers', function () { 
describe('AdminDogsCtrl', function () {
    beforeEach(module('dfwLabRescueApp'));

    it('should create dogs model with a bunch of dogs', inject(function ($controller) {
        var scope = {},
            ctrl = $controller('AdminDogsCtrl', { $scope: scope });

        expect(scope.dogs.length).toBe(10);
    }));
});
});