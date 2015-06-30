#!/bin/sh

set -e

/Applications/Unity/Unity.app/Contents/MacOS/Unity -batchmode -quit -projectPath ~/../Shared/Unity/Sample -executeMethod BuildBatch.Buildpackages -logFile /tmp/build.log; cat /tmp/build.log
