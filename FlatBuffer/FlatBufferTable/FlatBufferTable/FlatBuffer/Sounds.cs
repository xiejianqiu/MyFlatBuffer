// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_Sounds : Table {
  public static FB_Sounds GetRootAsFB_Sounds(ByteBuffer _bb) { return GetRootAsFB_Sounds(_bb, new FB_Sounds()); }
  public static FB_Sounds GetRootAsFB_Sounds(ByteBuffer _bb, FB_Sounds obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_Sounds __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public string FullPathName { get { int o = __offset(6); return o != 0 ? __string(o + bb_pos) : null; } }
  public float PanLevel { get { int o = __offset(8); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)1; } }
  public float Volume { get { int o = __offset(10); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)1; } }
  public float MinDistance { get { int o = __offset(12); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public bool IsLoop { get { int o = __offset(14); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)true; } }
  public float Delay { get { int o = __offset(16); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)0; } }
  public float FadeInTime { get { int o = __offset(18); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public float FadeOutTime { get { int o = __offset(20); return o != 0 ? bb.GetFloat(o + bb_pos) : (float)-1; } }
  public int NextSoundId { get { int o = __offset(22); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int WaitTime { get { int o = __offset(24); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public bool IsSceneBGM { get { int o = __offset(26); return o != 0 ? 0!=bb.Get(o + bb_pos) : (bool)false; } }

  public static Offset<FB_Sounds> CreateFB_Sounds(FlatBufferBuilder builder,
      int Id = 0,
      StringOffset FullPathName = default(StringOffset),
      float PanLevel = 1,
      float Volume = 1,
      float MinDistance = 0,
      bool IsLoop = true,
      float Delay = 0,
      float FadeInTime = -1,
      float FadeOutTime = -1,
      int NextSoundId = -1,
      int WaitTime = 0,
      bool IsSceneBGM = false) {
    builder.StartObject(12);
    FB_Sounds.AddWaitTime(builder, WaitTime);
    FB_Sounds.AddNextSoundId(builder, NextSoundId);
    FB_Sounds.AddFadeOutTime(builder, FadeOutTime);
    FB_Sounds.AddFadeInTime(builder, FadeInTime);
    FB_Sounds.AddDelay(builder, Delay);
    FB_Sounds.AddMinDistance(builder, MinDistance);
    FB_Sounds.AddVolume(builder, Volume);
    FB_Sounds.AddPanLevel(builder, PanLevel);
    FB_Sounds.AddFullPathName(builder, FullPathName);
    FB_Sounds.AddId(builder, Id);
    FB_Sounds.AddIsSceneBGM(builder, IsSceneBGM);
    FB_Sounds.AddIsLoop(builder, IsLoop);
    return FB_Sounds.EndFB_Sounds(builder);
  }

  public static void StartFB_Sounds(FlatBufferBuilder builder) { builder.StartObject(12); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddFullPathName(FlatBufferBuilder builder, StringOffset FullPathNameOffset) { builder.AddOffset(1, FullPathNameOffset.Value, 0); }
  public static void AddPanLevel(FlatBufferBuilder builder, float PanLevel) { builder.AddFloat(2, PanLevel, 1); }
  public static void AddVolume(FlatBufferBuilder builder, float Volume) { builder.AddFloat(3, Volume, 1); }
  public static void AddMinDistance(FlatBufferBuilder builder, float MinDistance) { builder.AddFloat(4, MinDistance, 0); }
  public static void AddIsLoop(FlatBufferBuilder builder, bool IsLoop) { builder.AddBool(5, IsLoop, true); }
  public static void AddDelay(FlatBufferBuilder builder, float Delay) { builder.AddFloat(6, Delay, 0); }
  public static void AddFadeInTime(FlatBufferBuilder builder, float FadeInTime) { builder.AddFloat(7, FadeInTime, -1); }
  public static void AddFadeOutTime(FlatBufferBuilder builder, float FadeOutTime) { builder.AddFloat(8, FadeOutTime, -1); }
  public static void AddNextSoundId(FlatBufferBuilder builder, int NextSoundId) { builder.AddInt(9, NextSoundId, -1); }
  public static void AddWaitTime(FlatBufferBuilder builder, int WaitTime) { builder.AddInt(10, WaitTime, 0); }
  public static void AddIsSceneBGM(FlatBufferBuilder builder, bool IsSceneBGM) { builder.AddBool(11, IsSceneBGM, false); }
  public static Offset<FB_Sounds> EndFB_Sounds(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_Sounds>(o);
  }
};

public sealed class FB_SoundsContainer : Table {
  public static FB_SoundsContainer GetRootAsFB_SoundsContainer(ByteBuffer _bb) { return GetRootAsFB_SoundsContainer(_bb, new FB_SoundsContainer()); }
  public static FB_SoundsContainer GetRootAsFB_SoundsContainer(ByteBuffer _bb, FB_SoundsContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_SoundsContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_SoundsContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_Sounds GetItems(int j) { return GetItems(new FB_Sounds(), j); }
  public FB_Sounds GetItems(FB_Sounds obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_SoundsContainer> CreateFB_SoundsContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_SoundsContainer.AddItems(builder, items);
    return FB_SoundsContainer.EndFB_SoundsContainer(builder);
  }

  public static void StartFB_SoundsContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_Sounds>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_SoundsContainer> EndFB_SoundsContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_SoundsContainer>(o);
  }
  public static void FinishFB_SoundsContainerBuffer(FlatBufferBuilder builder, Offset<FB_SoundsContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
