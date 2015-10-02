
(function () {
    "use strict";

    var app = angular
                .module("taskResourceMock",
                        ["ngMockE2E"]);

    app.run(function ($httpBackend) {
        var jobs = [
            {
                "jobId": 1,
                "jobName": "Leaf Rake",
                "startDate": "March 20, 2014",
                "endDate": "March 19, 2015",
                "comment": "Leaf rake with 48-inch wooden handle.",
                "status": "Complete",
                "technicianID":1
                
            },
            {
                "jobId": 2,
                "jobName": "Leaf Rake",
                "startDate": "March 20, 2014",
                "endDate": "March 19, 2015",
                "comment": "Leaf rake with 48-inch wooden handle.",
                "status": 9.00,
                "technicianID": 1
            },
            {
                "jobId": 3,
                "jobName": "Leaf Rake",
                "startDate": "March 20, 2014",
                "endDate": "March 19, 2015",
                "comment": "Leaf rake with 48-inch wooden handle.",
                "status": 9.00,
                "technicianID": 1
            },
            {
                "jobId": 4,
                "jobName": "Saw",
                "startDate": "May 15, 2009",
                "endDate": "15-inch steel blade hand saw",
                "comment": "Leaf rake with 48-inch wooden handle.",
                "status": 9.00,
                "technicianID": 1
               
            },
            {
                "jobId": 5,
                "jobName": "Video Game Controller",
                "startDate": "October 15, 2002",
                "endDate": "Standard two-button video game controller",
                "comment": "Leaf rake with 48-inch wooden handle.",
                "status": 9.00,
                "technicianID": 1
                
            }
        ];

        var jobUrl = "/api/jobs";

        $httpBackend.whenGET(jobUrl).respond(jobs);

        var editingRegex = new RegExp(jobUrl + "/[0-9][0-9]*", '');
        $httpBackend.whenGET(editingRegex).respond(function (method, url, data) {
            var job = {"jobId": 0};
            var parameters = url.split('/');
            var length = parameters.length;
            var id = parameters[length - 1];

            if (id > 0) {
                for (var i = 0; i < jobs.length; i++) {
                    if (jobs[i].jobId == id) {
                        job = jobs[i];
                        break;
                    }
                };
            }
            return [200, job, {}];
        });

        $httpBackend.whenPOST(jobUrl).respond(function (method, url, data) {
            var job = angular.fromJson(data);

            if (!job.jobId) {
                // new job Id
                job.jobId = jobs[jobs.length - 1].jobId + 1;
                jobs.push(job);
            }
            else {
                // Updated job
                for (var i = 0; i < jobs.length; i++) {
                    if (jobs[i].jobId == job.jobId) {
                        jobs[i] = job;
                        break;
                    }
                };
            }
            return [200, job, {}];
        });

        // Pass through any requests for application files
        $httpBackend.whenGET(/app/).passThrough();


    })
}());
