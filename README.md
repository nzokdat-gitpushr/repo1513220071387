# Getting started

## Welcome
GitPushr is a utility API that is designed to make interaction with various git providers more unified. 
You can do things like, list repos, create repos and event commit a zip file to a Repo with a commit message!

GitPushr API requires the username and password/token of the Git hosting provider to work. 
This information is passed in the header.

## How to Build

The generated code uses the Newtonsoft Json.NET NuGet Package. If the automatic NuGet package restore
is enabled, these dependencies will be installed automatically. Therefore,
you will need internet access for build.

"This library requires Visual Studio 2017 for compilation."
1. Open the solution (GitPushr.sln) file.
2. Invoke the build process using `Ctrl+Shift+B` shortcut key or using the `Build` menu as shown below.

![Building SDK using Visual Studio](https://apidocs.io/illustration/cs?step=buildSDK&workspaceFolder=GitPushr-CSharp&workspaceName=GitPushr&projectName=GitPushr.Standard)

## How to Use

The build process generates a portable class library, which can be used like a normal class library. The generated library is compatible with Windows Forms, Windows RT, Windows Phone 8,
Silverlight 5, Xamarin iOS, Xamarin Android and Mono. More information on how to use can be found at the [MSDN Portable Class Libraries documentation](http://msdn.microsoft.com/en-us/library/vstudio/gg597391%28v=vs.100%29.aspx).

The following section explains how to use the GitPushr library in a new console project.

### 1. Starting a new project

For starting a new project, right click on the current solution from the *solution explorer* and choose  ``` Add -> New Project ```.

![Add a new project in the existing solution using Visual Studio](https://apidocs.io/illustration/cs?step=addProject&workspaceFolder=GitPushr-CSharp&workspaceName=GitPushr&projectName=GitPushr.Standard)

Next, choose "Console Application", provide a ``` TestConsoleProject ``` as the project name and click ``` OK ```.

![Create a new console project using Visual Studio](https://apidocs.io/illustration/cs?step=createProject&workspaceFolder=GitPushr-CSharp&workspaceName=GitPushr&projectName=GitPushr.Standard)

### 2. Set as startup project

The new console project is the entry point for the eventual execution. This requires us to set the ``` TestConsoleProject ``` as the start-up project. To do this, right-click on the  ``` TestConsoleProject ``` and choose  ``` Set as StartUp Project ``` form the context menu.

![Set the new cosole project as the start up project](https://apidocs.io/illustration/cs?step=setStartup&workspaceFolder=GitPushr-CSharp&workspaceName=GitPushr&projectName=GitPushr.Standard)

### 3. Add reference of the library project

In order to use the GitPushr library in the new project, first we must add a projet reference to the ``` TestConsoleProject ```. First, right click on the ``` References ``` node in the *solution explorer* and click ``` Add Reference... ```.

![Open references of the TestConsoleProject](https://apidocs.io/illustration/cs?step=addReference&workspaceFolder=GitPushr-CSharp&workspaceName=GitPushr&projectName=GitPushr.Standard)

Next, a window will be displayed where we must set the ``` checkbox ``` on ``` GitPushr.Standard ``` and click ``` OK ```. By doing this, we have added a reference of the ```GitPushr.Standard``` project into the new ``` TestConsoleProject ```.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=createReference&workspaceFolder=GitPushr-CSharp&workspaceName=GitPushr&projectName=GitPushr.Standard)

### 4. Write sample code

Once the ``` TestConsoleProject ``` is created, a file named ``` Program.cs ``` will be visible in the *solution explorer* with an empty ``` Main ``` method. This is the entry point for the execution of the entire solution.
Here, you can add code to initialize the client library and acquire the instance of a *Controller* class. Sample code to initialize the client library and using controller methods is given in the subsequent sections.

![Add a reference to the TestConsoleProject](https://apidocs.io/illustration/cs?step=addCode&workspaceFolder=GitPushr-CSharp&workspaceName=GitPushr&projectName=GitPushr.Standard)

## How to Test

The generated SDK also contain one or more Tests, which are contained in the Tests project.
In order to invoke these test cases, you will need *NUnit 3.0 Test Adapter Extension for Visual Studio*.
Once the SDK is complied, the test cases should appear in the Test Explorer window.
Here, you can click *Run All* to execute these test cases.

## Initialization

### Authentication
In order to setup authentication and initialization of the API client, you need the following information.

| Parameter | Description |
|-----------|-------------|
| xUsername | Git username |
| xPassword | Git token |



API client can be initialized as following.

```csharp
// Configuration parameters and credentials
string xUsername = "xUsername"; // Git username
string xPassword = "xPassword"; // Git token

GitPushrClient client = new GitPushrClient(xUsername, xPassword);
```



# Class Reference

## <a name="list_of_controllers"></a>List of Controllers

* [BitbucketController](#bitbucket_controller)
* [GithubController](#github_controller)
* [GitController](#git_controller)
* [JobsController](#jobs_controller)

## <a name="bitbucket_controller"></a>![Class: ](https://apidocs.io/img/class.png "GitPushr.Standard.Controllers.BitbucketController") BitbucketController

### Get singleton instance

The singleton instance of the ``` BitbucketController ``` class can be accessed from the API Client.

```csharp
BitbucketController bitbucket = client.Bitbucket;
```

### <a name="create_repo"></a>![Method: ](https://apidocs.io/img/method.png "GitPushr.Standard.Controllers.BitbucketController.CreateRepo") CreateRepo

> Creates a Repo for an organisation or under personal account


```csharp
Task<Models.Repo> CreateRepo(Models.NewRepo body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Models.NewRepo();

Models.Repo result = await bitbucket.CreateRepo(body);

```


### <a name="list_repos"></a>![Method: ](https://apidocs.io/img/method.png "GitPushr.Standard.Controllers.BitbucketController.ListRepos") ListRepos

> Obtains the list of repos for the user using BitBucket API


```csharp
Task<List<Models.Repo>> ListRepos()
```

#### Example Usage

```csharp

List<Models.Repo> result = await bitbucket.ListRepos();

```


[Back to List of Controllers](#list_of_controllers)

## <a name="github_controller"></a>![Class: ](https://apidocs.io/img/class.png "GitPushr.Standard.Controllers.GithubController") GithubController

### Get singleton instance

The singleton instance of the ``` GithubController ``` class can be accessed from the API Client.

```csharp
GithubController github = client.Github;
```

### <a name="create_repo"></a>![Method: ](https://apidocs.io/img/method.png "GitPushr.Standard.Controllers.GithubController.CreateRepo") CreateRepo

> Creates a Repo for an organisation or under personal account


```csharp
Task<Models.Repo> CreateRepo(Models.NewRepo body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | TODO: Add a parameter description |


#### Example Usage

```csharp
var body = new Models.NewRepo();

Models.Repo result = await github.CreateRepo(body);

```


### <a name="list_repos"></a>![Method: ](https://apidocs.io/img/method.png "GitPushr.Standard.Controllers.GithubController.ListRepos") ListRepos

> Obtains the list of repos for the user using Github API


```csharp
Task<List<Models.Repo>> ListRepos()
```

#### Example Usage

```csharp

List<Models.Repo> result = await github.ListRepos();

```


[Back to List of Controllers](#list_of_controllers)

## <a name="git_controller"></a>![Class: ](https://apidocs.io/img/class.png "GitPushr.Standard.Controllers.GitController") GitController

### Get singleton instance

The singleton instance of the ``` GitController ``` class can be accessed from the API Client.

```csharp
GitController git = client.Git;
```

### <a name="create_commit_now"></a>![Method: ](https://apidocs.io/img/method.png "GitPushr.Standard.Controllers.GitController.CreateCommitNow") CreateCommitNow

> Commits a file immediately and waits for the job to complete before returning


```csharp
Task<Models.JobStatus> CreateCommitNow(Models.GitJob body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Job Details |


#### Example Usage

```csharp
var body = new Models.GitJob();

Models.JobStatus result = await git.CreateCommitNow(body);

```


### <a name="create_commit"></a>![Method: ](https://apidocs.io/img/method.png "GitPushr.Standard.Controllers.GitController.CreateCommit") CreateCommit

> Commits a file to the repo


```csharp
Task<Models.NewJobDetails> CreateCommit(Models.GitJob body)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| body |  ``` Required ```  | Job Details |


#### Example Usage

```csharp
var body = new Models.GitJob();

Models.NewJobDetails result = await git.CreateCommit(body);

```


[Back to List of Controllers](#list_of_controllers)

## <a name="jobs_controller"></a>![Class: ](https://apidocs.io/img/class.png "GitPushr.Standard.Controllers.JobsController") JobsController

### Get singleton instance

The singleton instance of the ``` JobsController ``` class can be accessed from the API Client.

```csharp
JobsController jobs = client.Jobs;
```

### <a name="get_job"></a>![Method: ](https://apidocs.io/img/method.png "GitPushr.Standard.Controllers.JobsController.GetJob") GetJob

> Returns the state of the job


```csharp
Task<Models.JobStatus> GetJob(string jobId)
```

#### Parameters

| Parameter | Tags | Description |
|-----------|------|-------------|
| jobId |  ``` Required ```  | The Job Id you want to check status for |


#### Example Usage

```csharp
string jobId = "job-id";

Models.JobStatus result = await jobs.GetJob(jobId);

```


[Back to List of Controllers](#list_of_controllers)



