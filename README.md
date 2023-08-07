# PenPositionSim

## Introduction
PenPositionSim is a simple "simulation" of how the pen position of a drawing tablet is interpreted.

You can independently control:
- Report rate
- Latency
- Amount of smoothing

## Building

```
dotnet publish PenPositionSim -c release --runtime win-x64 --framework net6.0-windows
```
