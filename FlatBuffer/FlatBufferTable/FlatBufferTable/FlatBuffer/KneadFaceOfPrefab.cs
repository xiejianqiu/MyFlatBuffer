// automatically generated, do not modify

namespace Shark
{

using FlatBuffers;

public sealed class FB_KneadFaceOfPrefab : Table {
  public static FB_KneadFaceOfPrefab GetRootAsFB_KneadFaceOfPrefab(ByteBuffer _bb) { return GetRootAsFB_KneadFaceOfPrefab(_bb, new FB_KneadFaceOfPrefab()); }
  public static FB_KneadFaceOfPrefab GetRootAsFB_KneadFaceOfPrefab(ByteBuffer _bb, FB_KneadFaceOfPrefab obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public FB_KneadFaceOfPrefab __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public int Id { get { int o = __offset(4); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int MenPai { get { int o = __offset(6); return o != 0 ? bb.GetInt(o + bb_pos) : (int)-1; } }
  public int Sex { get { int o = __offset(8); return o != 0 ? bb.GetInt(o + bb_pos) : (int)1; } }
  public string FacePath { get { int o = __offset(10); return o != 0 ? __string(o + bb_pos) : null; } }
  public int FaceType { get { int o = __offset(12); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetFaceValueList(int j) { int o = __offset(14); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int FaceValueListLength { get { int o = __offset(14); return o != 0 ? __vector_len(o) : 0; } }
  public int HairValue { get { int o = __offset(16); return o != 0 ? bb.GetInt(o + bb_pos) : (int)0; } }
  public int GetMakeUpValueList(int j) { int o = __offset(18); return o != 0 ? bb.GetInt(__vector(o) + j * 4) : (int)0; }
  public int MakeUpValueListLength { get { int o = __offset(18); return o != 0 ? __vector_len(o) : 0; } }
  public string PrefabIcon { get { int o = __offset(20); return o != 0 ? __string(o + bb_pos) : null; } }
  public string DescStr { get { int o = __offset(22); return o != 0 ? __string(o + bb_pos) : null; } }
  public string SecondDescStr { get { int o = __offset(24); return o != 0 ? __string(o + bb_pos) : null; } }

  public static Offset<FB_KneadFaceOfPrefab> CreateFB_KneadFaceOfPrefab(FlatBufferBuilder builder,
      int Id = 0,
      int MenPai = -1,
      int Sex = 1,
      StringOffset FacePath = default(StringOffset),
      int FaceType = 0,
      VectorOffset FaceValueList = default(VectorOffset),
      int HairValue = 0,
      VectorOffset MakeUpValueList = default(VectorOffset),
      StringOffset PrefabIcon = default(StringOffset),
      StringOffset DescStr = default(StringOffset),
      StringOffset SecondDescStr = default(StringOffset)) {
    builder.StartObject(11);
    FB_KneadFaceOfPrefab.AddSecondDescStr(builder, SecondDescStr);
    FB_KneadFaceOfPrefab.AddDescStr(builder, DescStr);
    FB_KneadFaceOfPrefab.AddPrefabIcon(builder, PrefabIcon);
    FB_KneadFaceOfPrefab.AddMakeUpValueList(builder, MakeUpValueList);
    FB_KneadFaceOfPrefab.AddHairValue(builder, HairValue);
    FB_KneadFaceOfPrefab.AddFaceValueList(builder, FaceValueList);
    FB_KneadFaceOfPrefab.AddFaceType(builder, FaceType);
    FB_KneadFaceOfPrefab.AddFacePath(builder, FacePath);
    FB_KneadFaceOfPrefab.AddSex(builder, Sex);
    FB_KneadFaceOfPrefab.AddMenPai(builder, MenPai);
    FB_KneadFaceOfPrefab.AddId(builder, Id);
    return FB_KneadFaceOfPrefab.EndFB_KneadFaceOfPrefab(builder);
  }

  public static void StartFB_KneadFaceOfPrefab(FlatBufferBuilder builder) { builder.StartObject(11); }
  public static void AddId(FlatBufferBuilder builder, int Id) { builder.AddInt(0, Id, 0); }
  public static void AddMenPai(FlatBufferBuilder builder, int MenPai) { builder.AddInt(1, MenPai, -1); }
  public static void AddSex(FlatBufferBuilder builder, int Sex) { builder.AddInt(2, Sex, 1); }
  public static void AddFacePath(FlatBufferBuilder builder, StringOffset FacePathOffset) { builder.AddOffset(3, FacePathOffset.Value, 0); }
  public static void AddFaceType(FlatBufferBuilder builder, int FaceType) { builder.AddInt(4, FaceType, 0); }
  public static void AddFaceValueList(FlatBufferBuilder builder, VectorOffset FaceValueListOffset) { builder.AddOffset(5, FaceValueListOffset.Value, 0); }
  public static VectorOffset CreateFaceValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartFaceValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddHairValue(FlatBufferBuilder builder, int HairValue) { builder.AddInt(6, HairValue, 0); }
  public static void AddMakeUpValueList(FlatBufferBuilder builder, VectorOffset MakeUpValueListOffset) { builder.AddOffset(7, MakeUpValueListOffset.Value, 0); }
  public static VectorOffset CreateMakeUpValueListVector(FlatBufferBuilder builder, int[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddInt(data[i]); return builder.EndVector(); }
  public static void StartMakeUpValueListVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static void AddPrefabIcon(FlatBufferBuilder builder, StringOffset PrefabIconOffset) { builder.AddOffset(8, PrefabIconOffset.Value, 0); }
  public static void AddDescStr(FlatBufferBuilder builder, StringOffset DescStrOffset) { builder.AddOffset(9, DescStrOffset.Value, 0); }
  public static void AddSecondDescStr(FlatBufferBuilder builder, StringOffset SecondDescStrOffset) { builder.AddOffset(10, SecondDescStrOffset.Value, 0); }
  public static Offset<FB_KneadFaceOfPrefab> EndFB_KneadFaceOfPrefab(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_KneadFaceOfPrefab>(o);
  }
};

public sealed class FB_KneadFaceOfPrefabContainer : Table {
  public static FB_KneadFaceOfPrefabContainer GetRootAsFB_KneadFaceOfPrefabContainer(ByteBuffer _bb) { return GetRootAsFB_KneadFaceOfPrefabContainer(_bb, new FB_KneadFaceOfPrefabContainer()); }
  public static FB_KneadFaceOfPrefabContainer GetRootAsFB_KneadFaceOfPrefabContainer(ByteBuffer _bb, FB_KneadFaceOfPrefabContainer obj) { return (obj.__init(_bb.GetInt(_bb.Position) + _bb.Position, _bb)); }
  public static bool FB_KneadFaceOfPrefabContainerBufferHasIdentifier(ByteBuffer _bb) { return __has_identifier(_bb, "swdt"); }
  public FB_KneadFaceOfPrefabContainer __init(int _i, ByteBuffer _bb) { bb_pos = _i; bb = _bb; return this; }

  public FB_KneadFaceOfPrefab GetItems(int j) { return GetItems(new FB_KneadFaceOfPrefab(), j); }
  public FB_KneadFaceOfPrefab GetItems(FB_KneadFaceOfPrefab obj, int j) { int o = __offset(4); return o != 0 ? obj.__init(__indirect(__vector(o) + j * 4), bb) : null; }
  public int ItemsLength { get { int o = __offset(4); return o != 0 ? __vector_len(o) : 0; } }

  public static Offset<FB_KneadFaceOfPrefabContainer> CreateFB_KneadFaceOfPrefabContainer(FlatBufferBuilder builder,
      VectorOffset items = default(VectorOffset)) {
    builder.StartObject(1);
    FB_KneadFaceOfPrefabContainer.AddItems(builder, items);
    return FB_KneadFaceOfPrefabContainer.EndFB_KneadFaceOfPrefabContainer(builder);
  }

  public static void StartFB_KneadFaceOfPrefabContainer(FlatBufferBuilder builder) { builder.StartObject(1); }
  public static void AddItems(FlatBufferBuilder builder, VectorOffset itemsOffset) { builder.AddOffset(0, itemsOffset.Value, 0); }
  public static VectorOffset CreateItemsVector(FlatBufferBuilder builder, Offset<FB_KneadFaceOfPrefab>[] data) { builder.StartVector(4, data.Length, 4); for (int i = data.Length - 1; i >= 0; i--) builder.AddOffset(data[i].Value); return builder.EndVector(); }
  public static void StartItemsVector(FlatBufferBuilder builder, int numElems) { builder.StartVector(4, numElems, 4); }
  public static Offset<FB_KneadFaceOfPrefabContainer> EndFB_KneadFaceOfPrefabContainer(FlatBufferBuilder builder) {
    int o = builder.EndObject();
    return new Offset<FB_KneadFaceOfPrefabContainer>(o);
  }
  public static void FinishFB_KneadFaceOfPrefabContainerBuffer(FlatBufferBuilder builder, Offset<FB_KneadFaceOfPrefabContainer> offset) { builder.Finish(offset.Value, "swdt"); }
};


}
