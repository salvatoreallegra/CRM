# Software Engineering Bootcamp Constitution

Version: 1.0

---

# Mission

Become a professional software engineer capable of designing, building, testing, debugging, deploying, securing, monitoring, and maintaining production-quality software using the modern Microsoft ecosystem.

The CRM project is the vehicle used to teach software engineering.

The goal is understanding, not memorization.

---

# Time Constraint

Two weeks.

Every lesson must maximize practical engineering value.

The course focuses on the knowledge and skills that produce the greatest real-world engineering capability in the available time.

---

# Technology Stack

## Operating System

- Windows 11

## IDE

- Visual Studio 2026 Community

## Languages

- C# 14
- SQL
- TypeScript
- JavaScript
- HTML
- CSS

## Frameworks

- .NET 10 LTS
- ASP.NET Core 10
- Entity Framework Core 10
- React
- Tailwind CSS

## Database

- SQL Server Developer Edition
- SQL Server Management Studio (SSMS)

## Cloud

- Azure

## Version Control

- Git
- GitHub

## CI/CD

- GitHub Actions

## Containers

- Docker Desktop

## API Testing

- Postman

## AI

- ChatGPT
- GitHub Copilot

---

# Course Philosophy

This course teaches software engineering.

.NET is the implementation platform.

Every topic should answer:

> Why does this exist?

Understanding is always more important than memorization.

---

# Teaching Method

Every lesson follows this structure.

1. Prediction
2. Reasoning
3. Demonstration
4. Implementation
5. Debugging
6. Code Review
7. Deployment
8. Reflection

The student should predict before being shown the answer whenever practical.

---

# Engineering Philosophy

- Business requirements before architecture.
- Architecture before implementation.
- Understanding before memorization.
- Modern engineering practices from Day One.
- Every design decision should be questioned.
- Tradeoffs should always be discussed.
- Software engineering is about reasoning, not syntax.

---

# Standing Rules

## Rule 1

Never assume prior knowledge.

If a new concept appears for the first time it must either:

- be explained immediately, or
- be explicitly scheduled for a future lesson.

---

## Rule 2

Teach from first principles before teaching frameworks.

---

## Rule 3

Every lesson must connect to previous lessons.

Nothing should feel isolated.

---

## Rule 4

Every lesson ends with:

- Summary
- Why it matters
- Connections
- Preview of the next lesson

---

## Rule 5

Every major concept should explain:

- Why it exists
- How it works internally
- When to use it
- When not to use it
- Common mistakes
- Performance implications
- Security implications
- Interview discussion

---

## Rule 6

Prefer diagrams over long paragraphs whenever possible.

---

## Rule 7

The CRM must remain deployable throughout the course.

Deployment is never postponed until the end.

---

## Rule 8

Every engineering concept should be introduced because a real engineering problem requires it.

Avoid teaching isolated topics simply because they traditionally appear in textbooks.

---

## Rule 9

Whenever possible, one business feature should reinforce multiple engineering concepts.

Example:

A single CRM feature may teach:

- HTTP
- Routing
- Dependency Injection
- EF Core
- SQL
- Testing
- Logging
- Performance
- CI/CD

---

# Engineering Workflow

Every feature follows the same lifecycle.

Business Requirement

↓

Architecture Discussion

↓

Acceptance Criteria

↓

Test Strategy

↓

Implementation

↓

Debugging

↓

Code Review

↓

Git Commit

↓

Pull Request

↓

Continuous Integration

↓

Continuous Deployment (Staging)

↓

Smoke Tests

↓

Retrospective

---

# Testing Standard

Testing is part of development.

Not something added later.

Use TDD whenever it improves design and protects business behavior.

Use:

- Unit Tests
- Integration Tests
- Smoke Tests

where appropriate.

---

# Continuous Integration Standard

Every push should automatically:

- Restore packages
- Build
- Run analyzers
- Execute tests
- Produce deployable artifacts

Broken builds block merges.

---

# Continuous Deployment Standard

Every successful merge should automatically deploy to a staging environment.

The deployment pipeline should exist before significant application development begins.

---

# Code Review Standard

Every completed feature should be reviewed for:

- Correctness
- Readability
- Maintainability
- Simplicity
- Performance
- Security
- Testability
- Architecture
- Error handling

---

# AI Usage Policy

AI is a professional engineering tool.

Acceptable uses include:

- Learning
- Debugging
- Code review
- Architecture discussion
- Boilerplate generation
- Documentation
- Test generation
- Refactoring suggestions

AI must never replace engineering judgment.

Every accepted line of generated code must be understood by the student.

---

# Definition of Mastery

A topic is mastered when the student can:

- Explain it
- Implement it
- Debug it
- Recognize poor implementations
- Teach it to another engineer

---

# Course Goal

The objective is not simply to finish a CRM.

The objective is to think like a professional software engineer.

The CRM is the laboratory used to develop that capability.

---

# Living Improvement Rule

Whenever a weakness in the course is discovered, it becomes part of the curriculum.

The curriculum should evolve exactly as professional software evolves.

---

# Current Technology Decisions

Repository

- SoftwareEngineeringBootcamp

Solution

- CRM

Primary Architecture

- To Be Determined during the architecture lessons.

Primary Cloud

- Azure

Primary Database

- SQL Server

Primary Source Control

- Git + GitHub

Primary CI/CD

- GitHub Actions

Primary Testing Strategy

- TDD where appropriate
- Unit Tests
- Integration Tests
- Smoke Tests

---

# Success Criteria

By the end of the bootcamp the student should be capable of:

- Designing software from requirements.
- Building production-quality ASP.NET applications.
- Working effectively with Git and GitHub.
- Writing automated tests.
- Debugging complex problems.
- Designing relational databases.
- Using Entity Framework Core effectively.
- Deploying to Azure.
- Building CI/CD pipelines.
- Using Docker.
- Applying modern software engineering practices.
- Using AI responsibly as a productivity tool.
- Explaining not only *how* a system works, but *why* it was designed that way.
