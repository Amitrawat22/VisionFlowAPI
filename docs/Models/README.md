Data Model (Entities & Relationships)

User.cs
Purpose:
Authentication
Owns uploaded videos

Video.cs
Purpose:
Metadata for uploaded video
Link to user
Link to analysis & processing job

VideoAnalysis.cs
Purpose:
Stores AI/ML results
Labels, timestamps, object detections
Generated after video is processed

ProcessingJob.cs
Purpose:
Background job status & metadata
Stores retries, start/finish time, current state
Used by Hangfire / background pipeline

Entity Relationship Overview
User (1)
   │
   ├───< Video (M)
   │         │
   │         ├─── VideoAnalysis (0/1)
   │         │
   │         └─── ProcessingJob (0/1)


Relationship Details
User → Video (1 → Many)

A user can upload multiple videos
Each video belongs to exactly one user

Video → VideoAnalysis (0 → 1)

A video may have:
0 → when it is uploaded and not yet processed
1 → after ML analysis is completed

Video → ProcessingJob (0 → 1)

A video may have:
0 → no processing has started
1 → a processing job exists
status: queued / running / failed / completed
