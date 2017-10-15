using System;
using System.Collections.Generic;
using System.Text;
using OpenTK;

public static partial class game_engine
{
    public static readonly Vector3[] anorms = new Vector3[q_shared.NUMVERTEXNORMALS]
    {
        new Vector3(-0.525731f, 0.000000f, 0.850651f),
        new Vector3(-0.442863f, 0.238856f, 0.864188f),
        new Vector3(-0.295242f, 0.000000f, 0.955423f),
        new Vector3(-0.309017f, 0.500000f, 0.809017f),
        new Vector3(-0.162460f, 0.262866f, 0.951056f),
        new Vector3(0.000000f, 0.000000f, 1.000000f),
        new Vector3(0.000000f, 0.850651f, 0.525731f),
        new Vector3(-0.147621f, 0.716567f, 0.681718f),
        new Vector3(0.147621f, 0.716567f, 0.681718f),
        new Vector3(0.000000f, 0.525731f, 0.850651f),
        new Vector3(0.309017f, 0.500000f, 0.809017f),
        new Vector3(0.525731f, 0.000000f, 0.850651f),
        new Vector3(0.295242f, 0.000000f, 0.955423f),
        new Vector3(0.442863f, 0.238856f, 0.864188f),
        new Vector3(0.162460f, 0.262866f, 0.951056f),
        new Vector3(-0.681718f, 0.147621f, 0.716567f),
        new Vector3(-0.809017f, 0.309017f, 0.500000f),
        new Vector3(-0.587785f, 0.425325f, 0.688191f),
        new Vector3(-0.850651f, 0.525731f, 0.000000f),
        new Vector3(-0.864188f, 0.442863f, 0.238856f),
        new Vector3(-0.716567f, 0.681718f, 0.147621f),
        new Vector3(-0.688191f, 0.587785f, 0.425325f),
        new Vector3(-0.500000f, 0.809017f, 0.309017f),
        new Vector3(-0.238856f, 0.864188f, 0.442863f),
        new Vector3(-0.425325f, 0.688191f, 0.587785f),
        new Vector3(-0.716567f, 0.681718f, -0.147621f),
        new Vector3(-0.500000f, 0.809017f, -0.309017f),
        new Vector3(-0.525731f, 0.850651f, 0.000000f),
        new Vector3(0.000000f, 0.850651f, -0.525731f),
        new Vector3(-0.238856f, 0.864188f, -0.442863f),
        new Vector3(0.000000f, 0.955423f, -0.295242f),
        new Vector3(-0.262866f, 0.951056f, -0.162460f),
        new Vector3(0.000000f, 1.000000f, 0.000000f),
        new Vector3(0.000000f, 0.955423f, 0.295242f),
        new Vector3(-0.262866f, 0.951056f, 0.162460f),
        new Vector3(0.238856f, 0.864188f, 0.442863f),
        new Vector3(0.262866f, 0.951056f, 0.162460f),
        new Vector3(0.500000f, 0.809017f, 0.309017f),
        new Vector3(0.238856f, 0.864188f, -0.442863f),
        new Vector3(0.262866f, 0.951056f, -0.162460f),
        new Vector3(0.500000f, 0.809017f, -0.309017f),
        new Vector3(0.850651f, 0.525731f, 0.000000f),
        new Vector3(0.716567f, 0.681718f, 0.147621f),
        new Vector3(0.716567f, 0.681718f, -0.147621f),
        new Vector3(0.525731f, 0.850651f, 0.000000f),
        new Vector3(0.425325f, 0.688191f, 0.587785f),
        new Vector3(0.864188f, 0.442863f, 0.238856f),
        new Vector3(0.688191f, 0.587785f, 0.425325f),
        new Vector3(0.809017f, 0.309017f, 0.500000f),
        new Vector3(0.681718f, 0.147621f, 0.716567f),
        new Vector3(0.587785f, 0.425325f, 0.688191f),
        new Vector3(0.955423f, 0.295242f, 0.000000f),
        new Vector3(1.000000f, 0.000000f, 0.000000f),
        new Vector3(0.951056f, 0.162460f, 0.262866f),
        new Vector3(0.850651f, -0.525731f, 0.000000f),
        new Vector3(0.955423f, -0.295242f, 0.000000f),
        new Vector3(0.864188f, -0.442863f, 0.238856f),
        new Vector3(0.951056f, -0.162460f, 0.262866f),
        new Vector3(0.809017f, -0.309017f, 0.500000f),
        new Vector3(0.681718f, -0.147621f, 0.716567f),
        new Vector3(0.850651f, 0.000000f, 0.525731f),
        new Vector3(0.864188f, 0.442863f, -0.238856f),
        new Vector3(0.809017f, 0.309017f, -0.500000f),
        new Vector3(0.951056f, 0.162460f, -0.262866f),
        new Vector3(0.525731f, 0.000000f, -0.850651f),
        new Vector3(0.681718f, 0.147621f, -0.716567f),
        new Vector3(0.681718f, -0.147621f, -0.716567f),
        new Vector3(0.850651f, 0.000000f, -0.525731f),
        new Vector3(0.809017f, -0.309017f, -0.500000f),
        new Vector3(0.864188f, -0.442863f, -0.238856f),
        new Vector3(0.951056f, -0.162460f, -0.262866f),
        new Vector3(0.147621f, 0.716567f, -0.681718f),
        new Vector3(0.309017f, 0.500000f, -0.809017f),
        new Vector3(0.425325f, 0.688191f, -0.587785f),
        new Vector3(0.442863f, 0.238856f, -0.864188f),
        new Vector3(0.587785f, 0.425325f, -0.688191f),
        new Vector3(0.688191f, 0.587785f, -0.425325f),
        new Vector3(-0.147621f, 0.716567f, -0.681718f),
        new Vector3(-0.309017f, 0.500000f, -0.809017f),
        new Vector3(0.000000f, 0.525731f, -0.850651f),
        new Vector3(-0.525731f, 0.000000f, -0.850651f),
        new Vector3(-0.442863f, 0.238856f, -0.864188f),
        new Vector3(-0.295242f, 0.000000f, -0.955423f),
        new Vector3(-0.162460f, 0.262866f, -0.951056f),
        new Vector3(0.000000f, 0.000000f, -1.000000f),
        new Vector3(0.295242f, 0.000000f, -0.955423f),
        new Vector3(0.162460f, 0.262866f, -0.951056f),
        new Vector3(-0.442863f, -0.238856f, -0.864188f),
        new Vector3(-0.309017f, -0.500000f, -0.809017f),
        new Vector3(-0.162460f, -0.262866f, -0.951056f),
        new Vector3(0.000000f, -0.850651f, -0.525731f),
        new Vector3(-0.147621f, -0.716567f, -0.681718f),
        new Vector3(0.147621f, -0.716567f, -0.681718f),
        new Vector3(0.000000f, -0.525731f, -0.850651f),
        new Vector3(0.309017f, -0.500000f, -0.809017f),
        new Vector3(0.442863f, -0.238856f, -0.864188f),
        new Vector3(0.162460f, -0.262866f, -0.951056f),
        new Vector3(0.238856f, -0.864188f, -0.442863f),
        new Vector3(0.500000f, -0.809017f, -0.309017f),
        new Vector3(0.425325f, -0.688191f, -0.587785f),
        new Vector3(0.716567f, -0.681718f, -0.147621f),
        new Vector3(0.688191f, -0.587785f, -0.425325f),
        new Vector3(0.587785f, -0.425325f, -0.688191f),
        new Vector3(0.000000f, -0.955423f, -0.295242f),
        new Vector3(0.000000f, -1.000000f, 0.000000f),
        new Vector3(0.262866f, -0.951056f, -0.162460f),
        new Vector3(0.000000f, -0.850651f, 0.525731f),
        new Vector3(0.000000f, -0.955423f, 0.295242f),
        new Vector3(0.238856f, -0.864188f, 0.442863f),
        new Vector3(0.262866f, -0.951056f, 0.162460f),
        new Vector3(0.500000f, -0.809017f, 0.309017f),
        new Vector3(0.716567f, -0.681718f, 0.147621f),
        new Vector3(0.525731f, -0.850651f, 0.000000f),
        new Vector3(-0.238856f, -0.864188f, -0.442863f),
        new Vector3(-0.500000f, -0.809017f, -0.309017f),
        new Vector3(-0.262866f, -0.951056f, -0.162460f),
        new Vector3(-0.850651f, -0.525731f, 0.000000f),
        new Vector3(-0.716567f, -0.681718f, -0.147621f),
        new Vector3(-0.716567f, -0.681718f, 0.147621f),
        new Vector3(-0.525731f, -0.850651f, 0.000000f),
        new Vector3(-0.500000f, -0.809017f, 0.309017f),
        new Vector3(-0.238856f, -0.864188f, 0.442863f),
        new Vector3(-0.262866f, -0.951056f, 0.162460f),
        new Vector3(-0.864188f, -0.442863f, 0.238856f),
        new Vector3(-0.809017f, -0.309017f, 0.500000f),
        new Vector3(-0.688191f, -0.587785f, 0.425325f),
        new Vector3(-0.681718f, -0.147621f, 0.716567f),
        new Vector3(-0.442863f, -0.238856f, 0.864188f),
        new Vector3(-0.587785f, -0.425325f, 0.688191f),
        new Vector3(-0.309017f, -0.500000f, 0.809017f),
        new Vector3(-0.147621f, -0.716567f, 0.681718f),
        new Vector3(-0.425325f, -0.688191f, 0.587785f),
        new Vector3(-0.162460f, -0.262866f, 0.951056f),
        new Vector3(0.442863f, -0.238856f, 0.864188f),
        new Vector3(0.162460f, -0.262866f, 0.951056f),
        new Vector3(0.309017f, -0.500000f, 0.809017f),
        new Vector3(0.147621f, -0.716567f, 0.681718f),
        new Vector3(0.000000f, -0.525731f, 0.850651f),
        new Vector3(0.425325f, -0.688191f, 0.587785f),
        new Vector3(0.587785f, -0.425325f, 0.688191f),
        new Vector3(0.688191f, -0.587785f, 0.425325f),
        new Vector3(-0.955423f, 0.295242f, 0.000000f),
        new Vector3(-0.951056f, 0.162460f, 0.262866f),
        new Vector3(-1.000000f, 0.000000f, 0.000000f),
        new Vector3(-0.850651f, 0.000000f, 0.525731f),
        new Vector3(-0.955423f, -0.295242f, 0.000000f),
        new Vector3(-0.951056f, -0.162460f, 0.262866f),
        new Vector3(-0.864188f, 0.442863f, -0.238856f),
        new Vector3(-0.951056f, 0.162460f, -0.262866f),
        new Vector3(-0.809017f, 0.309017f, -0.500000f),
        new Vector3(-0.864188f, -0.442863f, -0.238856f),
        new Vector3(-0.951056f, -0.162460f, -0.262866f),
        new Vector3(-0.809017f, -0.309017f, -0.500000f),
        new Vector3(-0.681718f, 0.147621f, -0.716567f),
        new Vector3(-0.681718f, -0.147621f, -0.716567f),
        new Vector3(-0.850651f, 0.000000f, -0.525731f),
        new Vector3(-0.688191f, 0.587785f, -0.425325f),
        new Vector3(-0.587785f, 0.425325f, -0.688191f),
        new Vector3(-0.425325f, 0.688191f, -0.587785f),
        new Vector3(-0.425325f, -0.688191f, -0.587785f),
        new Vector3(-0.587785f, -0.425325f, -0.688191f),
        new Vector3(-0.688191f, -0.587785f, -0.425325f)
    };
}