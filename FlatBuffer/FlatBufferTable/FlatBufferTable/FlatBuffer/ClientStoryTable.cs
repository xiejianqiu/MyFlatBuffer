// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_ClientStoryTable : Table {
  public static FB_ClientStoryTable GetRootAsFB_ClientStoryTable(ByteBuffer _bb) { return GetRootAsFB_ClientStoryTable(_bb, new FB_ClientStoryTable()); }
  public static FB_ClientStoryTable GetRootAsFB_ClientStoryTable(ByteBuffer _bb, FB_ClientStoryTable obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_ClientStoryTable __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public float TargetPosX { get { int o = __offset(6); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float TargetPosY { get { int o = __offset(8); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float TargetPosZ { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float TargetPosRadius { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)2; } }
  public int SpeakerID { get { int o = __offset(14); return o != 0 ? bb.GetInt(o + bb_pos) : (int)491; } }
  public int AnimationID { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public string SpriteName { get { int o = __offset(18); return o != 0 ? __string(o + bb_pos) : null; } }
  public string Story { get { int o = __offset(20); return o != 0 ? __string(o + bb_pos) : null; } }
  public float NextPageTime { get { int o = __offset(22); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)7; } }
  public int SoundID { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int NextId { get { int o = __offset(26); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public string RoleName { get { int o = __offset(28); return o != 0 ? __string(o + bb_pos) : null; } }
  public bool IsShowFakeObj { get { int o = __offset(30); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }

  public static Offset<FB_ClientStoryTable> CreateFB_ClientStoryTable(FlatBufferBuilder builder,
      int Id = 0,
      float TargetPosX = 0,
      float TargetPosY = 0,
      float TargetPosZ = 0,
      float TargetPosRadius = 2,
      int SpeakerID = 491,
      int AnimationID = 1,
      StringOffset SpriteName = default(StringOffset),
      StringOffset Story = default(StringOffset),
      float NextPageTime = 7,
      int SoundID = -1,
      int NextId = -1,
      StringOffset RoleName = default(StringOffset),
      bool IsShowFakeObj = true) {
    builder.StartObject(14);
    FB_ClientStoryTable.AddRoleName(builder, RoleName);
    FB_ClientStoryTable.AddNextId(builder, NextId);
    FB_ClientStoryTable.AddSoundID(builder, SoundID);
    FB_ClientStoryTable.AddNextPageTime(builder, NextPageTime);
    FB_ClientStoryTable.AddStory(builder, Story);
    FB_ClientStoryTable.AddSpriteName(builder, SpriteName);
    FB_ClientStoryTable.AddAnimationID(builder, AnimationID);
    FB_ClientStoryTable.AddSpeakerID(builder, SpeakerID);
    FB_ClientStoryTable.AddTargetPosRadius(builder, TargetPosRadius);
    FB_ClientStoryTable.AddTargetPosZ(builder, TargetPosZ);
    FB_ClientStoryTable.AddTargetPosY(builder, TargetPosY);
    FB_ClientStoryTable.AddTargetPosX(builder, TargetPosX);
    FB_ClientStoryTable.AddId(builder, Id);
    FB_ClientStoryTable.AddIsShowFakeObj(builder, IsShowFakeObj);
    return FB_ClientStoryTable.EndFB_ClientStoryTable(builder);
  }

  public static void StartFB_ClientStoryTable(FlatBufferBuilder builder) { builder.StartObject(14); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddTargetPosX(FlatBufferBuilder builder, float TargetPosX) { builder.AddFloat(1, TargetPosX, 0); }
  public static void AddTargetPosY(FlatBufferBuilder builder, float TargetPosY) { builder.AddFloat(2, TargetPosY, 0); }
  public static void AddTargetPosZ(FlatBufferBuilder builder, float TargetPosZ) { builder.AddFloat(3, TargetPosZ, 0); }
  public static void AddTargetPosRadius(FlatBufferBuilder builder, float TargetPosRadius) { builder.AddFloat(4, TargetPosRadius, 2); }
  public static void AddSpeakerID(FlatBufferBuilder builder, int SpeakerID) { builder.AddInt(5, SpeakerID, 491); }
  public static void AddAnimationID(FlatBufferBuilder builder, int AnimationID) { builder.AddInt(6, AnimationID, 1); }
  public static void AddSpriteName(FlatBufferBuilder builder, StringOffset SpriteNameOffset) { builder.AddOffset(7, SpriteNameOffset.Value, 0); }
  public static void AddStory(FlatBufferBuilder builder, StringOffset StoryOffset) { builder.AddOffset(8, StoryOffset.Value, 0); }
  public static void AddNextPageTime(FlatBufferBuilder builder, float NextPageTime) { builder.AddFloat(9, NextPageTime, 7); }
  public static void AddSoundID(FlatBufferBuilder builder, int SoundID) { builder.AddInt(10, SoundID, -1); }
  public static void AddNextId(FlatBufferBuilder builder, int NextId) { builder.AddInt(11, NextId, -1); }
  public static void AddRoleName(FlatBufferBuilder builder, StringOffset RoleNameOffset) { builder.AddOffset(12, RoleNameOffset.Value, 0); }
  public static void AddIsShowFakeObj(FlatBufferBuilder builder, bool IsShowFakeObj) { builder.AddBool(13, IsShowFakeObj, true); }
  public static Offset<FB_ClientStoryTable> EndFB_ClientStoryTable(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ClientStoryTable>(o);
  }
};

public sealed class FB_ClientStoryTableContainer : Table {
  public static FB_ClientStoryTableContainer GetRootAsFB_ClientStoryTableContainer(ByteBuffer _bb) { return GetRootAsFB_ClientStoryTableContainer(_bb, new FB_ClientStoryTableContainer()); }
  public static FB_ClientStoryTableContainer GetRootAsFB_ClientStoryTableContainer(ByteBuffer _bb, FB_ClientStoryTableContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_ClientStoryTableContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_ClientStoryTableContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_ClientStoryTable GetItems(int j) { return GetItems(new FB_ClientStoryTable(), j); }
  public FB_ClientStoryTable GetItems(FB_ClientStoryTable obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_ClientStoryTableContainer> CreateFB_ClientStoryTableContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_ClientStoryTableContainer.AddItems(builder, items);
    return FB_ClientStoryTableContainer.EndFB_ClientStoryTableContainer(builder);
  }

  public static void StartFB_ClientStoryTableContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_ClientStoryTable>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_ClientStoryTableContainer> EndFB_ClientStoryTableContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_ClientStoryTableContainer>(o);
  }
  public static void FinishFB_ClientStoryTableContainerBuffer(FlatBufferBuilder builder, Offset<FB_ClientStoryTableContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
