![Build status](https://github.com/quicktype/quicktype/actions/workflows/master.yaml/badge.svg)

**FinApp** is the easiest way to build and deploy infrastructure, of any architecture and on any cloud, using programming languages that you already know and love. Code and ship infrastructure faster with your favorite languages and tools, and embed IaC anywhere with [Automation API](https://www.pulumi.com/docs/guides/automation-api/?utm_source=github.com&utm_medium=referral&utm_campaign=pulumi-pulumi-github-repo&utm_content=automation+api).

Simply write code in your favorite language and Pulumi automatically provisions and manages your resources on approach.
Skip the YAML, and use standard language features like loops, functions, classes,
and package management that you already know and love.

For example, create three web servers:

```typescript
const aws = require("@pulumi/aws");
const sg = new aws.ec2.SecurityGroup("web-sg", {
    ingress: [{ protocol: "tcp", fromPort: 80, toPort: 80, cidrBlocks: ["0.0.0.0/0"] }],
});
for (let i = 0; i < 3; i++) {
    new aws.ec2.Instance(`web-${i}`, {
        ami: "ami-7172b611",
        instanceType: "t2.micro",
        vpcSecurityGroupIds: [sg.id],
        userData: `#!/bin/bash
            echo "Hello, World!" > index.html
            nohup python -m SimpleHTTPServer 80 &`,
    });
}
```

Or a simple serverless timer that archives Hacker News every day at 8:30AM:

```typescript
const aws = require("@pulumi/aws");

const snapshots = new aws.dynamodb.Table("snapshots", {
    attributes: [{ name: "id", type: "S", }],
    hashKey: "id", billingMode: "PAY_PER_REQUEST",
});

aws.cloudwatch.onSchedule("daily-yc-snapshot", "cron(30 8 * * ? *)", () => {
    require("https").get("https://news.ycombinator.com", res => {
        let content = "";
        res.setEncoding("utf8");
        res.on("data", chunk => content += chunk);
        res.on("end", () => new aws.sdk.DynamoDB.DocumentClient().put({
            TableName: snapshots.name.get(),
            Item: { date: Date.now(), content },
        }).promise());
    }).end();
});
```

Many examples are available spanning containers, serverless, and infrastructure in
[pulumi/examples](https://github.com/pulumi/examples).

